using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000698")]
public class LevelSignalFlare : BaseLevelObject
{
	[Token(Token = "0x40048BE")]
	[FieldOffset(Offset = "0x74")]
	private bool m_NeedDestroy;

	[Token(Token = "0x40048BF")]
	[FieldOffset(Offset = "0x78")]
	private GameObject m_EffectObj;

	[Token(Token = "0x40048C0")]
	[FieldOffset(Offset = "0x7C")]
	private ResourceID m_EffectResID;

	[Token(Token = "0x6002A54")]
	[Address(RVA = "0xEBF1A4", Offset = "0xEBF1A4", VA = "0xEBF1A4")]
	public LevelSignalFlare()
	{
	}

	[Token(Token = "0x6002A55")]
	[Address(RVA = "0xEBF244", Offset = "0xEBF244", VA = "0xEBF244", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002A56")]
	[Address(RVA = "0xEBF2A8", Offset = "0xEBF2A8", VA = "0xEBF2A8", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002A57")]
	[Address(RVA = "0xEBF30C", Offset = "0xEBF30C", VA = "0xEBF30C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002A58")]
	[Address(RVA = "0xEBF3B0", Offset = "0xEBF3B0", VA = "0xEBF3B0", Slot = "31")]
	public override void SyncAction(object[] param)
	{
	}

	[Token(Token = "0x6002A59")]
	[Address(RVA = "0xEBF9EC", Offset = "0xEBF9EC", VA = "0xEBF9EC")]
	public bool OnAirDropLanded()
	{
		return default(bool);
	}

	[Token(Token = "0x6002A5A")]
	[Address(RVA = "0xEBFA6C", Offset = "0xEBFA6C", VA = "0xEBFA6C")]
	private void DestorySignalFlare()
	{
	}

	[Token(Token = "0x6002A5B")]
	[Address(RVA = "0xEBFFB4", Offset = "0xEBFFB4", VA = "0xEBFFB4")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002A5C")]
	[Address(RVA = "0xEBFFBC", Offset = "0xEBFFBC", VA = "0xEBFFBC")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002A5D")]
	[Address(RVA = "0xEBFFC4", Offset = "0xEBFFC4", VA = "0xEBFFC4")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
