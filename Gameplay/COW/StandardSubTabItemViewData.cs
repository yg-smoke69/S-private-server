using System;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023BF")]
public class StandardSubTabItemViewData
{
	[Token(Token = "0x400DE72")]
	[FieldOffset(Offset = "0x8")]
	public string tabName;

	[Token(Token = "0x400DE73")]
	[FieldOffset(Offset = "0xC")]
	public ETipsType tipType;

	[Token(Token = "0x400DE74")]
	[FieldOffset(Offset = "0x10")]
	public EEventTag eventTag;

	[Token(Token = "0x400DE75")]
	[FieldOffset(Offset = "0x14")]
	public Action onClick;

	[Token(Token = "0x400DE76")]
	[FieldOffset(Offset = "0x18")]
	public object extraPara;

	[Token(Token = "0x400DE77")]
	[FieldOffset(Offset = "0x1C")]
	public bool hasRedPoint;

	[Token(Token = "0x400DE78")]
	[FieldOffset(Offset = "0x20")]
	public Action onTipChange;

	[Token(Token = "0x600C966")]
	[Address(RVA = "0x288E160", Offset = "0x288E160", VA = "0x288E160")]
	public StandardSubTabItemViewData(string tabName, ETipsType tipType = ETipsType.None, EEventTag eventTag = EEventTag.NONE)
	{
	}
}
