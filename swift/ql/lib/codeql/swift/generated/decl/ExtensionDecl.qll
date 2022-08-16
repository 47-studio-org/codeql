// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.decl.Decl
import codeql.swift.elements.decl.GenericContext
import codeql.swift.elements.decl.IterableDeclContext
import codeql.swift.elements.decl.NominalTypeDecl

class ExtensionDeclBase extends Synth::TExtensionDecl, Decl, GenericContext, IterableDeclContext {
  override string getAPrimaryQlClass() { result = "ExtensionDecl" }

  NominalTypeDecl getImmediateExtendedTypeDecl() {
    result =
      Synth::convertNominalTypeDeclFromRaw(Synth::convertExtensionDeclToRaw(this)
            .(Raw::ExtensionDecl)
            .getExtendedTypeDecl())
  }

  final NominalTypeDecl getExtendedTypeDecl() { result = getImmediateExtendedTypeDecl().resolve() }
}
