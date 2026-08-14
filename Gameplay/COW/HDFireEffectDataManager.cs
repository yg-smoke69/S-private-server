using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200014D")]
public class HDFireEffectDataManager : SingletonModule<HDFireEffectDataManager>
{
	[Token(Token = "0x4000863")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, HDFireEffectData> m_HDFireEffectDic;

	[Token(Token = "0x60007CE")]
	[Address(RVA = "0x1210CC8", Offset = "0x1210CC8", VA = "0x1210CC8")]
	public HDFireEffectDataManager()
	{
	}

	[Token(Token = "0x60007CF")]
	[Address(RVA = "0x1210D8C", Offset = "0x1210D8C", VA = "0x1210D8C", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60007D0")]
	[Address(RVA = "0x1210FE4", Offset = "0x1210FE4", VA = "0x1210FE4", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60007D1")]
	[Address(RVA = "0x12110A4", Offset = "0x12110A4", VA = "0x12110A4")]
	public ResourceID GetEffectIndexByRandom(uint weaponType, float num)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60007D2")]
	[Address(RVA = "0x1211284", Offset = "0x1211284", VA = "0x1211284")]
	private int CalculateIndex(List<float> list, float num)
	{
		return default(int);
	}
}
