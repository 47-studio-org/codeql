// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.expr.Argument
import codeql.swift.elements.expr.Expr

class ApplyExprBase extends Synth::TApplyExpr, Expr {
  Expr getImmediateFunction() {
    result =
      Synth::convertExprFromRaw(Synth::convertApplyExprToRaw(this).(Raw::ApplyExpr).getFunction())
  }

  final Expr getFunction() { result = getImmediateFunction().resolve() }

  Argument getImmediateArgument(int index) {
    result =
      Synth::convertArgumentFromRaw(Synth::convertApplyExprToRaw(this)
            .(Raw::ApplyExpr)
            .getArgument(index))
  }

  final Argument getArgument(int index) { result = getImmediateArgument(index).resolve() }

  final Argument getAnArgument() { result = getArgument(_) }

  final int getNumberOfArguments() { result = count(getAnArgument()) }
}
