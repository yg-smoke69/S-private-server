using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x20026BD")]
public class UIGuildSignInController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20026BE")]
	private sealed class _003CPlayFirstAnim_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EF19")]
		[FieldOffset(Offset = "0x8")]
		internal bool isForward;

		[Token(Token = "0x400EF1A")]
		[FieldOffset(Offset = "0xC")]
		internal UIGuildSignInController _0024this;

		[Token(Token = "0x600EA08")]
		[Address(RVA = "0x147B278", Offset = "0x147B278", VA = "0x147B278")]
		public _003CPlayFirstAnim_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EA09")]
		[Address(RVA = "0x147B8F0", Offset = "0x147B8F0", VA = "0x147B8F0")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600EA0A")]
		[Address(RVA = "0x147B928", Offset = "0x147B928", VA = "0x147B928")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400EF12")]
	[FieldOffset(Offset = "0x48")]
	private UIGuildSignInView m_View;

	[Token(Token = "0x400EF13")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIGuildSignInItemController> m_Items;

	[Token(Token = "0x400EF14")]
	[FieldOffset(Offset = "0x50")]
	private bool m_IsJumpToNextClan;

	[Token(Token = "0x400EF15")]
	[FieldOffset(Offset = "0x54")]
	private ClanLevelData m_CurLevelData;

	[Token(Token = "0x400EF16")]
	[FieldOffset(Offset = "0x58")]
	private ClanLevelData m_NextLevelData;

	[Token(Token = "0x400EF17")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_FirstDelayCallID;

	[Token(Token = "0x400EF18")]
	[FieldOffset(Offset = "0x60")]
	private uint m_SecondDelayCallID;

	[Token(Token = "0x1700119F")]
	private bool m_HasNextLevel
	{
		[Token(Token = "0x600E9FA")]
		[Address(RVA = "0x1479294", Offset = "0x1479294", VA = "0x1479294")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600E9F9")]
	[Address(RVA = "0x1479200", Offset = "0x1479200", VA = "0x1479200")]
	public UIGuildSignInController()
	{
	}

	[Token(Token = "0x600E9FB")]
	[Address(RVA = "0x14792A4", Offset = "0x14792A4", VA = "0x14792A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E9FC")]
	[Address(RVA = "0x1479308", Offset = "0x1479308", VA = "0x1479308", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600E9FD")]
	[Address(RVA = "0x147934C", Offset = "0x147934C", VA = "0x147934C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E9FE")]
	[Address(RVA = "0x147A6CC", Offset = "0x147A6CC", VA = "0x147A6CC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E9FF")]
	[Address(RVA = "0x147A89C", Offset = "0x147A89C", VA = "0x147A89C")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x600EA00")]
	[Address(RVA = "0x147A8A4", Offset = "0x147A8A4", VA = "0x147A8A4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600EA01")]
	[Address(RVA = "0x147A8AC", Offset = "0x147A8AC", VA = "0x147A8AC", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600EA02")]
	[Address(RVA = "0x1479940", Offset = "0x1479940", VA = "0x1479940")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600EA03")]
	[Address(RVA = "0x147ABE8", Offset = "0x147ABE8", VA = "0x147ABE8")]
	private void OnClickNextClan()
	{
	}

	[Token(Token = "0x600EA04")]
	[Address(RVA = "0x147AC0C", Offset = "0x147AC0C", VA = "0x147AC0C")]
	private void PlayFirstAnim(bool isForward)
	{
	}

	[Token(Token = "0x600EA05")]
	[Address(RVA = "0x147B280", Offset = "0x147B280", VA = "0x147B280")]
	private void PlaySecondAnim(bool isForward)
	{
	}

	[Token(Token = "0x600EA06")]
	[Address(RVA = "0x147B868", Offset = "0x147B868", VA = "0x147B868")]
	private void _003CPlaySecondAnim_003Em__0()
	{
	}

	[Token(Token = "0x600EA07")]
	[Address(RVA = "0x147B8AC", Offset = "0x147B8AC", VA = "0x147B8AC")]
	private void _003CPlaySecondAnim_003Em__1()
	{
	}
}
