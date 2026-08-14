using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023C3")]
public class StandardTabItemViewData
{
	[Token(Token = "0x400DE82")]
	[FieldOffset(Offset = "0x8")]
	public string tabName;

	[Token(Token = "0x400DE83")]
	[FieldOffset(Offset = "0xC")]
	public string tabBgName;

	[Token(Token = "0x400DE84")]
	[FieldOffset(Offset = "0x10")]
	public ETipsType tipType;

	[Token(Token = "0x400DE85")]
	[FieldOffset(Offset = "0x14")]
	public EEventTag eventTag;

	[Token(Token = "0x400DE86")]
	[FieldOffset(Offset = "0x18")]
	public Action onClick;

	[Token(Token = "0x400DE87")]
	[FieldOffset(Offset = "0x1C")]
	public bool hasRedPoint;

	[Token(Token = "0x400DE88")]
	[FieldOffset(Offset = "0x20")]
	public object extraPara;

	[Token(Token = "0x400DE89")]
	[FieldOffset(Offset = "0x24")]
	public bool clearTagOnClick;

	[Token(Token = "0x600C993")]
	[Address(RVA = "0x288E190", Offset = "0x288E190", VA = "0x288E190")]
	public StandardTabItemViewData(string tabName, ETipsType tipType = ETipsType.None, EEventTag eventTag = EEventTag.NONE, string tabSpriteName = "", [Optional] Action onClick, [Optional] object extraPara)
	{
	}
}
