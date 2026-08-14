using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003255")]
internal class UIModelShowAnim : UIBaseModel
{
	[Token(Token = "0x2003256")]
	private sealed class _003CReplaceAnimDataByAB_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013257")]
		[FieldOffset(Offset = "0x8")]
		internal FullscreenABTestDesc desc;

		[Token(Token = "0x60153BD")]
		[Address(RVA = "0x30F20BC", Offset = "0x30F20BC", VA = "0x30F20BC")]
		public _003CReplaceAnimDataByAB_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60153BE")]
		[Address(RVA = "0x30F3590", Offset = "0x30F3590", VA = "0x30F3590")]
		internal bool _003C_003Em__0(FullscreenCgDesc Item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4013255")]
	[FieldOffset(Offset = "0xC")]
	private List<FullscreenCgDesc> fullscreen_cgs;

	[Token(Token = "0x4013256")]
	[FieldOffset(Offset = "0x10")]
	private List<FullscreenItemDesc> fullscreen_items;

	[Token(Token = "0x60153B2")]
	[Address(RVA = "0x30F0FCC", Offset = "0x30F0FCC", VA = "0x30F0FCC")]
	public UIModelShowAnim()
	{
	}

	[Token(Token = "0x60153B3")]
	[Address(RVA = "0x30F1050", Offset = "0x30F1050", VA = "0x30F1050", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60153B4")]
	[Address(RVA = "0x30F10A8", Offset = "0x30F10A8", VA = "0x30F10A8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60153B5")]
	[Address(RVA = "0x30F1184", Offset = "0x30F1184", VA = "0x30F1184")]
	public void SetAnimData(CSGetFullscreenCgRes res)
	{
	}

	[Token(Token = "0x60153B6")]
	[Address(RVA = "0x30F11F8", Offset = "0x30F11F8", VA = "0x30F11F8")]
	public void SetItemAnimData(CSGetFullscreenItemRes res)
	{
	}

	[Token(Token = "0x60153B7")]
	[Address(RVA = "0x30F126C", Offset = "0x30F126C", VA = "0x30F126C")]
	public void ReplaceAnimDataByAB(CSGetFullscreenABTestRes res)
	{
	}

	[Token(Token = "0x60153B8")]
	[Address(RVA = "0x30F20C4", Offset = "0x30F20C4", VA = "0x30F20C4")]
	public int CheckFullScreenItem(uint itemid)
	{
		return default(int);
	}

	[Token(Token = "0x60153B9")]
	[Address(RVA = "0x30F22A8", Offset = "0x30F22A8", VA = "0x30F22A8")]
	public List<FullscreenCgDesc> FullScreenAnimByNavType(UINavigationUtil.UINavigationPageType type)
	{
		return null;
	}

	[Token(Token = "0x60153BA")]
	[Address(RVA = "0x30F2470", Offset = "0x30F2470", VA = "0x30F2470")]
	public bool NeedDownloadFullScreen_TwoPeopleAnim(FullscreenCgDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x60153BB")]
	[Address(RVA = "0x30F2CA0", Offset = "0x30F2CA0", VA = "0x30F2CA0")]
	public DownloadInfoSpecific GetDownloadInfoSpecific(FullscreenCgDesc desc)
	{
		return null;
	}

	[Token(Token = "0x60153BC")]
	[Address(RVA = "0x30F3588", Offset = "0x30F3588", VA = "0x30F3588")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
