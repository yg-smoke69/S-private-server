using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002081")]
public class UICupMatchTeamCreateFormController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CBC4")]
	[FieldOffset(Offset = "0x48")]
	private NationFlagData m_SelectNationFlag;

	[Token(Token = "0x400CBC5")]
	[FieldOffset(Offset = "0x4C")]
	private HeadPicBaseInfo m_ClanAvatarInfo;

	[Token(Token = "0x400CBC6")]
	[FieldOffset(Offset = "0x50")]
	private BannerBaseInfo m_ClanBannerInfo;

	[Token(Token = "0x400CBC7")]
	[FieldOffset(Offset = "0x54")]
	private UICupMatchTeamCreateFormView m_View;

	[Token(Token = "0x400CBC8")]
	[FieldOffset(Offset = "0x58")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBC9")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400CBCA")]
	[FieldOffset(Offset = "0x60")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBCB")]
	[FieldOffset(Offset = "0x64")]
	private bool m_IsCreatTing;

	[Token(Token = "0x600A6FB")]
	[Address(RVA = "0x2AB83F0", Offset = "0x2AB83F0", VA = "0x2AB83F0")]
	public UICupMatchTeamCreateFormController()
	{
	}

	[Token(Token = "0x600A6FC")]
	[Address(RVA = "0x2AB83F8", Offset = "0x2AB83F8", VA = "0x2AB83F8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A6FD")]
	[Address(RVA = "0x2AB84A0", Offset = "0x2AB84A0", VA = "0x2AB84A0")]
	public void InitUI(int key)
	{
	}

	[Token(Token = "0x600A6FE")]
	[Address(RVA = "0x2AB8CA8", Offset = "0x2AB8CA8", VA = "0x2AB8CA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A6FF")]
	[Address(RVA = "0x2AB8ED0", Offset = "0x2AB8ED0", VA = "0x2AB8ED0")]
	private void Confirm()
	{
	}

	[Token(Token = "0x600A700")]
	[Address(RVA = "0x2AB92C8", Offset = "0x2AB92C8", VA = "0x2AB92C8")]
	private void SelectFlag()
	{
	}

	[Token(Token = "0x600A701")]
	[Address(RVA = "0x2AB93D8", Offset = "0x2AB93D8", VA = "0x2AB93D8")]
	private void SelectAvatar()
	{
	}

	[Token(Token = "0x600A702")]
	[Address(RVA = "0x2AB94E8", Offset = "0x2AB94E8", VA = "0x2AB94E8")]
	private void SelectBanner()
	{
	}

	[Token(Token = "0x600A703")]
	[Address(RVA = "0x2AB95F8", Offset = "0x2AB95F8", VA = "0x2AB95F8", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A704")]
	[Address(RVA = "0x2AB97EC", Offset = "0x2AB97EC", VA = "0x2AB97EC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A705")]
	[Address(RVA = "0x2AB9880", Offset = "0x2AB9880", VA = "0x2AB9880")]
	private void NationalFlagSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A706")]
	[Address(RVA = "0x2AB99E8", Offset = "0x2AB99E8", VA = "0x2AB99E8")]
	private void ClanAvatarSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A707")]
	[Address(RVA = "0x2AB9B6C", Offset = "0x2AB9B6C", VA = "0x2AB9B6C")]
	private void ClanBannerSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A708")]
	[Address(RVA = "0x2AB9D34", Offset = "0x2AB9D34", VA = "0x2AB9D34")]
	private void _003CInitUI_003Em__0()
	{
	}

	[Token(Token = "0x600A709")]
	[Address(RVA = "0x2AB9DD0", Offset = "0x2AB9DD0", VA = "0x2AB9DD0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
