using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200414F")]
public class UIItemVariable : MonoBehaviour
{
	[Token(Token = "0x401B682")]
	[FieldOffset(Offset = "0xC")]
	public EUIItemExportType ExportType;

	[Token(Token = "0x401B683")]
	[FieldOffset(Offset = "0x10")]
	public string CustomExportTypeName;

	[Token(Token = "0x401B684")]
	[FieldOffset(Offset = "0x14")]
	public string ExportName;

	[Token(Token = "0x401B685")]
	[FieldOffset(Offset = "0x18")]
	public Object ExportObject;

	[Token(Token = "0x601AAED")]
	[Address(RVA = "0x2CA4320", Offset = "0x2CA4320", VA = "0x2CA4320")]
	public UIItemVariable()
	{
	}

	[Token(Token = "0x601AAEE")]
	[Address(RVA = "0x2CA4328", Offset = "0x2CA4328", VA = "0x2CA4328")]
	public void TryToAttachObject()
	{
	}

	[Token(Token = "0x601AAEF")]
	[Address(RVA = "0x2CA4250", Offset = "0x2CA4250", VA = "0x2CA4250")]
	public string GetExportedName()
	{
		return null;
	}

	[Token(Token = "0x601AAF0")]
	[Address(RVA = "0x2CA49A0", Offset = "0x2CA49A0", VA = "0x2CA49A0")]
	public string GetEUIItemExportTypeCorrespondOriginTypeName(EUIItemExportType euiItemExportType, UIItemVariable InItemVar)
	{
		return null;
	}
}
