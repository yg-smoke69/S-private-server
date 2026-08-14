using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002EE5")]
public class BigEventTemplateRuleConfig
{
	[Token(Token = "0x4011E86")]
	[FieldOffset(Offset = "0x8")]
	public Color titleColor;

	[Token(Token = "0x4011E87")]
	[FieldOffset(Offset = "0x18")]
	public Color closeColor;

	[Token(Token = "0x4011E88")]
	[FieldOffset(Offset = "0x28")]
	public string bgCDN;

	[Token(Token = "0x4011E89")]
	[FieldOffset(Offset = "0x2C")]
	public UIModelBigEventTemplate.LocStrWithColor textContent;

	[Token(Token = "0x60139EF")]
	[Address(RVA = "0x180970C", Offset = "0x180970C", VA = "0x180970C")]
	public BigEventTemplateRuleConfig()
	{
	}
}
