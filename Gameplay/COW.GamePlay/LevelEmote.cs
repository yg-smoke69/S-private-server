using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000616")]
public class LevelEmote : BaseLevelObject
{
	[Token(Token = "0x40045CE")]
	[FieldOffset(Offset = "0x74")]
	public MeshRenderer m_EmoteModelRender;

	[Token(Token = "0x40045CF")]
	[FieldOffset(Offset = "0x78")]
	public uint m_EmoteID;

	[Token(Token = "0x60025A1")]
	[Address(RVA = "0x271A544", Offset = "0x271A544", VA = "0x271A544")]
	public LevelEmote()
	{
	}

	[Token(Token = "0x60025A2")]
	[Address(RVA = "0x271A54C", Offset = "0x271A54C", VA = "0x271A54C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60025A3")]
	[Address(RVA = "0x271A5F0", Offset = "0x271A5F0", VA = "0x271A5F0", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60025A4")]
	[Address(RVA = "0x271A654", Offset = "0x271A654", VA = "0x271A654", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60025A5")]
	[Address(RVA = "0x271A7E0", Offset = "0x271A7E0", VA = "0x271A7E0", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60025A6")]
	[Address(RVA = "0x271A838", Offset = "0x271A838", VA = "0x271A838")]
	private void BGFDNPPAKMC(bool JGLJDJFHPBO, bool DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x60025A7")]
	[Address(RVA = "0x271A940", Offset = "0x271A940", VA = "0x271A940")]
	public bool IsUsed()
	{
		return default(bool);
	}

	[Token(Token = "0x60025A8")]
	[Address(RVA = "0x271AA64", Offset = "0x271AA64", VA = "0x271AA64")]
	public void InitLevelEmote(uint MJKNGMDNEAJ)
	{
	}

	[Token(Token = "0x60025A9")]
	[Address(RVA = "0x271ADB8", Offset = "0x271ADB8", VA = "0x271ADB8")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60025AA")]
	[Address(RVA = "0x271ADC0", Offset = "0x271ADC0", VA = "0x271ADC0")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60025AB")]
	[Address(RVA = "0x271ADC8", Offset = "0x271ADC8", VA = "0x271ADC8")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}
}
