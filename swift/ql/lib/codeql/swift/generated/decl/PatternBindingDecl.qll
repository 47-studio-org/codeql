// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.decl.Decl
import codeql.swift.elements.expr.Expr
import codeql.swift.elements.pattern.Pattern

class PatternBindingDeclBase extends Synth::TPatternBindingDecl, Decl {
  override string getAPrimaryQlClass() { result = "PatternBindingDecl" }

  Expr getImmediateInit(int index) {
    result =
      Synth::convertExprFromRaw(Synth::convertPatternBindingDeclToRaw(this)
            .(Raw::PatternBindingDecl)
            .getInit(index))
  }

  final Expr getInit(int index) { result = getImmediateInit(index).resolve() }

  final predicate hasInit(int index) { exists(getInit(index)) }

  final Expr getAnInit() { result = getInit(_) }

  Pattern getImmediatePattern(int index) {
    result =
      Synth::convertPatternFromRaw(Synth::convertPatternBindingDeclToRaw(this)
            .(Raw::PatternBindingDecl)
            .getPattern(index))
  }

  final Pattern getPattern(int index) { result = getImmediatePattern(index).resolve() }

  final Pattern getAPattern() { result = getPattern(_) }

  final int getNumberOfPatterns() { result = count(getAPattern()) }
}
