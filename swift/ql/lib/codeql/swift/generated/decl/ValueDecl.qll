// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.decl.Decl
import codeql.swift.elements.type.Type

class ValueDeclBase extends Synth::TValueDecl, Decl {
  Type getImmediateInterfaceType() {
    result =
      Synth::convertTypeFromRaw(Synth::convertValueDeclToRaw(this)
            .(Raw::ValueDecl)
            .getInterfaceType())
  }

  final Type getInterfaceType() { result = getImmediateInterfaceType().resolve() }
}
