using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000D4B")]
internal class HotupdaterGame : COWGameBase
{
	[Token(Token = "0x4006B31")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ResourceID[] SCENE_RESOURCE_LIST;

	[Token(Token = "0x60065F1")]
	[Address(RVA = "0x190DE34", Offset = "0x190DE34", VA = "0x190DE34")]
	public HotupdaterGame()
	{
	}

	[Token(Token = "0x60065F2")]
	[Address(RVA = "0x190DE3C", Offset = "0x190DE3C", VA = "0x190DE3C", Slot = "18")]
	public override ResourceID[] GetResourceID()
	{
		return null;
	}

	[Token(Token = "0x60065F3")]
	[Address(RVA = "0x190DF14", Offset = "0x190DF14", VA = "0x190DF14", Slot = "19")]
	public override Type GetUISceneType()
	{
		return null;
	}

	[Token(Token = "0x60065F4")]
	[Address(RVA = "0x190DFF0", Offset = "0x190DFF0", VA = "0x190DFF0", Slot = "26")]
	public override int GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x60065F5")]
	[Address(RVA = "0x190E048", Offset = "0x190E048", VA = "0x190E048", Slot = "9")]
	protected override void OnSceneLoaded()
	{
	}

	[Token(Token = "0x60065F7")]
	[Address(RVA = "0x190E20C", Offset = "0x190E20C", VA = "0x190E20C")]
	public int _003C_003EiFixBaseProxy_GetGameType()
	{
		return default(int);
	}

	[Token(Token = "0x60065F8")]
	[Address(RVA = "0x190E214", Offset = "0x190E214", VA = "0x190E214")]
	public new void _003C_003EiFixBaseProxy_OnSceneLoaded()
	{
	}
}
