// generated by codegen/codegen.py
private import codeql.swift.generated.Synth
private import codeql.swift.generated.Raw
import codeql.swift.elements.Element

class FileBase extends Synth::TFile, Element {
  string getName() { result = Synth::convertFileToRaw(this).(Raw::File).getName() }
}
