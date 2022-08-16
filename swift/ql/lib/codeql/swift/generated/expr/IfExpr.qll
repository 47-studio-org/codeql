// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.expr.Expr

class IfExprBase extends Synth::TIfExpr, Expr {
  override string getAPrimaryQlClass() { result = "IfExpr" }

  Expr getImmediateCondition() {
    result = Synth::convertExprFromRaw(Synth::convertIfExprToRaw(this).(Raw::IfExpr).getCondition())
  }

  final Expr getCondition() { result = getImmediateCondition().resolve() }

  Expr getImmediateThenExpr() {
    result = Synth::convertExprFromRaw(Synth::convertIfExprToRaw(this).(Raw::IfExpr).getThenExpr())
  }

  final Expr getThenExpr() { result = getImmediateThenExpr().resolve() }

  Expr getImmediateElseExpr() {
    result = Synth::convertExprFromRaw(Synth::convertIfExprToRaw(this).(Raw::IfExpr).getElseExpr())
  }

  final Expr getElseExpr() { result = getImmediateElseExpr().resolve() }
}
