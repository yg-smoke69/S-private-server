using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200333F")]
public class TriggerDetailStyleDataManager : SingletonModule<TriggerDetailStyleDataManager>
{
	[Token(Token = "0x4013878")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<uint, TriggerDetailStyleData> TriggerDetailDataDict;

	[Token(Token = "0x6015C57")]
	[Address(RVA = "0x232FDC8", Offset = "0x232FDC8", VA = "0x232FDC8")]
	public TriggerDetailStyleDataManager()
	{
	}

	[Token(Token = "0x6015C58")]
	[Address(RVA = "0x232FE8C", Offset = "0x232FE8C", VA = "0x232FE8C", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6015C59")]
	[Address(RVA = "0x232FF4C", Offset = "0x232FF4C", VA = "0x232FF4C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6015C5A")]
	[Address(RVA = "0x23301CC", Offset = "0x23301CC", VA = "0x23301CC")]
	public TriggerDetailStyleData GetTriggerDetailDataById(uint id)
	{
		return null;
	}
}
