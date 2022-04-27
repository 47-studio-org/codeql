import python
import semmle.python.frameworks.data.internal.AccessPathSyntax as AccessPathSyntax
import semmle.python.frameworks.data.ModelsAsData
import semmle.python.dataflow.new.TaintTracking
import semmle.python.dataflow.new.DataFlow
private import semmle.python.ApiGraphs

// TODO:
/*
 * class Steps extends ModelInput::SummaryModelCsv {
 *  override predicate row(string row) {
 *    // package;type;path;input;output;kind
 *    row =
 *      [
 *        "testlib;;Member[preserveTaint];Argument[0];ReturnValue;taint",
 *        "testlib;;Member[taintIntoCallback];Argument[0];Argument[1..2].Parameter[0];taint",
 *        "testlib;;Member[taintIntoCallbackThis];Argument[0];Argument[1..2].Parameter[this];taint",
 *        "testlib;;Member[preserveArgZeroAndTwo];Argument[0,2];ReturnValue;taint",
 *        "testlib;;Member[preserveAllButFirstArgument];Argument[1..];ReturnValue;taint",
 *        "testlib;;Member[preserveAllIfCall].Call;Argument[0..];ReturnValue;taint",
 *        "testlib;;Member[getSource].ReturnValue.Member[continue];Argument[this];ReturnValue;taint",
 *      ]
 *  }
 * }
 */

class Types extends ModelInput::TypeModelCsv {
  override predicate row(string row) {
    // package1;type1;package2;type2;path
    row =
      [
        "testlib;Alias;testlib;;Member[alias].ReturnValue",
        "testlib;Alias;testlib;Alias;Member[chain].ReturnValue",
      ]
  }
}

class Sinks extends ModelInput::SinkModelCsv {
  override predicate row(string row) {
    // package;type;path;kind
    row =
      [
        "testlib;;Member[mySink].Argument[0,sinkName:];test-sink",
        // testing argument syntax
        "testlib;;Member[Args].Member[arg0].Argument[0];test-source", //
        "testlib;;Member[Args].Member[arg1to3].Argument[1..3];test-source", //
        "testlib;;Member[Args].Member[lastarg].Argument[N-1];test-source", //
        "testlib;;Member[Args].Member[nonFist].Argument[1..];test-source", //
        // callsite filter.
        "testlib;;Member[CallFilter].Member[arityOne].WithArity[1].Argument[0..];test-source", //
        "testlib;;Member[CallFilter].Member[twoOrMore].WithArity[2..].Argument[0..];test-source", //
      ]
  }
}

// TODO: Uniform tokens for fields
// TODO: Non-positional arguments (including Named parameters)
// TODO: Any argument
// TODO: Test taint steps.
// TODO: Should `instance()` be shorthand for `subClass*().getReturn()`?
// TODO: // There are no API-graph edges for: ArrayElement, Element, MapKey, MapValue (remove from valid tokens list)
class Sources extends ModelInput::SourceModelCsv {
  // package;type;path;kind
  override predicate row(string row) {
    row =
      [
        "testlib;;Member[getSource].ReturnValue;test-source", //
        "testlib;Alias;;test-source",
        // testing parameter syntax
        "testlib;;Member[Callbacks].Member[first].Argument[0].Parameter[0];test-source", //
        "testlib;;Member[Callbacks].Member[param1to3].Argument[0].Parameter[1..3];test-source", //
        "testlib;;Member[Callbacks].Member[nonFirst].Argument[0].Parameter[1..];test-source", //
        // Common tokens.
        "testlib;;Member[CommonTokens].Member[makePromise].ReturnValue.Awaited;test-source", //
        "testlib;;Member[CommonTokens].Member[Class].Instance;test-source", //
        "testlib;;Member[CommonTokens].Member[Super].Subclass.Instance;test-source", //
      ]
  }
}

class BasicTaintTracking extends TaintTracking::Configuration {
  BasicTaintTracking() { this = "BasicTaintTracking" }

  override predicate isSource(DataFlow::Node source) {
    source = ModelOutput::getASourceNode("test-source").getAnImmediateUse()
  }

  override predicate isSink(DataFlow::Node sink) {
    sink = ModelOutput::getASinkNode("test-sink").getARhs()
  }
}

query predicate taintFlow(DataFlow::Node source, DataFlow::Node sink) {
  any(BasicTaintTracking tr).hasFlow(source, sink)
}

query predicate isSink(DataFlow::Node node, string kind) {
  node = ModelOutput::getASinkNode(kind).getARhs()
}

query predicate isSource(DataFlow::Node node, string kind) {
  node = ModelOutput::getASourceNode(kind).getAnImmediateUse()
}

class SyntaxErrorTest extends ModelInput::SinkModelCsv {
  override predicate row(string row) {
    row =
      [
        "testlib;;Member[foo],Member[bar];test-sink", "testlib;;Member[foo] Member[bar];test-sink",
        "testlib;;Member[foo]. Member[bar];test-sink",
        "testlib;;Member[foo], Member[bar];test-sink",
        "testlib;;Member[foo]..Member[bar];test-sink",
        "testlib;;Member[foo] .Member[bar];test-sink", "testlib;;Member[foo]Member[bar];test-sink",
        "testlib;;Member[foo;test-sink", "testlib;;Member[foo]];test-sink",
        "testlib;;Member[foo]].Member[bar];test-sink"
      ]
  }
}

query predicate syntaxErrors(AccessPathSyntax::AccessPath path) { path.hasSyntaxError() }

query predicate warning = ModelOutput::getAWarning/0;
