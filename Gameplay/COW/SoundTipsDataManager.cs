using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E37")]
public class SoundTipsDataManager : SingletonModule<SoundTipsDataManager>
{
	[Token(Token = "0x4011AC5")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, SoundTipsData> m_SoundTipsDict;

	[Token(Token = "0x601353C")]
	[Address(RVA = "0x20F3A9C", Offset = "0x20F3A9C", VA = "0x20F3A9C")]
	public SoundTipsDataManager()
	{
	}

	[Token(Token = "0x601353D")]
	[Address(RVA = "0x20F3B60", Offset = "0x20F3B60", VA = "0x20F3B60", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601353E")]
	[Address(RVA = "0x20F3DAC", Offset = "0x20F3DAC", VA = "0x20F3DAC", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601353F")]
	[Address(RVA = "0x20F3E74", Offset = "0x20F3E74", VA = "0x20F3E74")]
	public SoundTipsData FindAchievementDataByID(int id)
	{
		return null;
	}
}
