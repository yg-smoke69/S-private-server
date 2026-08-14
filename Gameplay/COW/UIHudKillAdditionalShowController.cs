using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200279B")]
internal class UIHudKillAdditionalShowController : UIBaseController
{
	[Token(Token = "0x200279C")]
	private sealed class _003CTryPlayAdditionalShow_003Ec__AnonStorey0
	{
		[Token(Token = "0x400F491")]
		[FieldOffset(Offset = "0x8")]
		internal float showSecs;

		[Token(Token = "0x400F492")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudKillAdditionalShowController _0024this;

		[Token(Token = "0x600F421")]
		[Address(RVA = "0x20B5034", Offset = "0x20B5034", VA = "0x20B5034")]
		public _003CTryPlayAdditionalShow_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600F422")]
		[Address(RVA = "0x20B52AC", Offset = "0x20B52AC", VA = "0x20B52AC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600F423")]
		[Address(RVA = "0x20B5488", Offset = "0x20B5488", VA = "0x20B5488")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400F48A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudKillAdditionalShowView m_View;

	[Token(Token = "0x400F48B")]
	[FieldOffset(Offset = "0x2C")]
	private Player curKiller;

	[Token(Token = "0x400F48C")]
	[FieldOffset(Offset = "0x30")]
	private Player curBeKill;

	[Token(Token = "0x400F48D")]
	[FieldOffset(Offset = "0x34")]
	protected uint m_HideDelayCall;

	[Token(Token = "0x400F48E")]
	[FieldOffset(Offset = "0x38")]
	private uint m_RevengeDelayCall;

	[Token(Token = "0x400F48F")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_KillKillerKingDelayCall;

	[Token(Token = "0x400F490")]
	private const float ADDITIONAL_SHOW_DELAY = 0.1f;

	[Token(Token = "0x600F41A")]
	[Address(RVA = "0x20B4734", Offset = "0x20B4734", VA = "0x20B4734")]
	public UIHudKillAdditionalShowController()
	{
	}

	[Token(Token = "0x600F41B")]
	[Address(RVA = "0x20B47B8", Offset = "0x20B47B8", VA = "0x20B47B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F41C")]
	[Address(RVA = "0x20B485C", Offset = "0x20B485C", VA = "0x20B485C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F41D")]
	[Address(RVA = "0x20B4978", Offset = "0x20B4978", VA = "0x20B4978")]
	private void TryPlayAdditionalShow(object[] data)
	{
	}

	[Token(Token = "0x600F41E")]
	[Address(RVA = "0x20B503C", Offset = "0x20B503C", VA = "0x20B503C")]
	protected void Show(float secs, ResourceID soundID)
	{
	}

	[Token(Token = "0x600F41F")]
	[Address(RVA = "0x20B5278", Offset = "0x20B5278", VA = "0x20B5278")]
	private void _003CShow_003Em__0()
	{
	}

	[Token(Token = "0x600F420")]
	[Address(RVA = "0x20B52A4", Offset = "0x20B52A4", VA = "0x20B52A4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
