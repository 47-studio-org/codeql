// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.expr.Expr
import codeql.swift.elements.pattern.Pattern

class UnresolvedPatternExprBase extends Synth::TUnresolvedPatternExpr, Expr {
  override string getAPrimaryQlClass() { result = "UnresolvedPatternExpr" }

  Pattern getImmediateSubPattern() {
    result =
      Synth::convertPatternFromRaw(Synth::convertUnresolvedPatternExprToRaw(this)
            .(Raw::UnresolvedPatternExpr)
            .getSubPattern())
  }

  final Pattern getSubPattern() { result = getImmediateSubPattern().resolve() }
}
