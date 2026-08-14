using System.Text;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C59")]
internal class DebugInfoUI : MonoBehaviour
{
	[Token(Token = "0x4010EB2")]
	[FieldOffset(Offset = "0xC")]
	public UILabel dynamicLabel;

	[Token(Token = "0x4010EB3")]
	[FieldOffset(Offset = "0x10")]
	public UILabel staticLabel;

	[Token(Token = "0x4010EB4")]
	[FieldOffset(Offset = "0x14")]
	private StringBuilder staticInfo;

	[Token(Token = "0x4010EB5")]
	[FieldOffset(Offset = "0x18")]
	private StringBuilder dynamicInfo;

	[Token(Token = "0x6012818")]
	[Address(RVA = "0x1C89DCC", Offset = "0x1C89DCC", VA = "0x1C89DCC")]
	public DebugInfoUI()
	{
	}

	[Token(Token = "0x6012819")]
	[Address(RVA = "0x1C89E60", Offset = "0x1C89E60", VA = "0x1C89E60")]
	private void Update()
	{
	}
}
