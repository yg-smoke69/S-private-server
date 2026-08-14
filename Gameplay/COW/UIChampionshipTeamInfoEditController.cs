using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200201F")]
public class UIChampionshipTeamInfoEditController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400C9B5")]
	[FieldOffset(Offset = "0x48")]
	private NationFlagData m_SelectNationFlag;

	[Token(Token = "0x400C9B6")]
	[FieldOffset(Offset = "0x4C")]
	private HeadPicBaseInfo m_ClanAvatarInfo;

	[Token(Token = "0x400C9B7")]
	[FieldOffset(Offset = "0x50")]
	private BannerBaseInfo m_ClanBannerInfo;

	[Token(Token = "0x400C9B8")]
	[FieldOffset(Offset = "0x54")]
	private UIChampionshipTeamCreateFormView m_View;

	[Token(Token = "0x400C9B9")]
	[FieldOffset(Offset = "0x58")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C9BA")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400C9BB")]
	[FieldOffset(Offset = "0x60")]
	private int m_SelectChannelID;

	[Token(Token = "0x400C9BC")]
	[FieldOffset(Offset = "0x64")]
	private List<uint> m_WaitModelPropIDs;

	[Token(Token = "0x400C9BD")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasErr;

	[Token(Token = "0x600A2AB")]
	[Address(RVA = "0x283EB64", Offset = "0x283EB64", VA = "0x283EB64")]
	public UIChampionshipTeamInfoEditController()
	{
	}

	[Token(Token = "0x600A2AC")]
	[Address(RVA = "0x283EBF0", Offset = "0x283EBF0", VA = "0x283EBF0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A2AD")]
	[Address(RVA = "0x283EC94", Offset = "0x283EC94", VA = "0x283EC94", Slot = "33")]
	public override string CustomTitle()
	{
		return null;
	}

	[Token(Token = "0x600A2AE")]
	[Address(RVA = "0x283ED38", Offset = "0x283ED38", VA = "0x283ED38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A2AF")]
	[Address(RVA = "0x283FD94", Offset = "0x283FD94", VA = "0x283FD94", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A2B0")]
	[Address(RVA = "0x283F830", Offset = "0x283F830", VA = "0x283F830")]
	private void InitContactInfo()
	{
	}

	[Token(Token = "0x600A2B1")]
	[Address(RVA = "0x2840024", Offset = "0x2840024", VA = "0x2840024")]
	private void Confirm()
	{
	}

	[Token(Token = "0x600A2B2")]
	[Address(RVA = "0x28408E0", Offset = "0x28408E0", VA = "0x28408E0")]
	private string GetFixContactInfo()
	{
		return null;
	}

	[Token(Token = "0x600A2B3")]
	[Address(RVA = "0x2840A94", Offset = "0x2840A94", VA = "0x2840A94")]
	private void SelectFlag()
	{
	}

	[Token(Token = "0x600A2B4")]
	[Address(RVA = "0x2840BA4", Offset = "0x2840BA4", VA = "0x2840BA4")]
	private void SelectChannel()
	{
	}

	[Token(Token = "0x600A2B5")]
	[Address(RVA = "0x2840CB4", Offset = "0x2840CB4", VA = "0x2840CB4")]
	private void SelectAvatar()
	{
	}

	[Token(Token = "0x600A2B6")]
	[Address(RVA = "0x2840DC4", Offset = "0x2840DC4", VA = "0x2840DC4")]
	private void SelectBanner()
	{
	}

	[Token(Token = "0x600A2B7")]
	[Address(RVA = "0x2840ED4", Offset = "0x2840ED4", VA = "0x2840ED4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A2B8")]
	[Address(RVA = "0x28414F0", Offset = "0x28414F0", VA = "0x28414F0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A2B9")]
	[Address(RVA = "0x2841584", Offset = "0x2841584", VA = "0x2841584")]
	private void NationalFlagSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A2BA")]
	[Address(RVA = "0x28416EC", Offset = "0x28416EC", VA = "0x28416EC")]
	private void ClanAvatarSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A2BB")]
	[Address(RVA = "0x2841870", Offset = "0x2841870", VA = "0x2841870")]
	private void ClanBannerSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A2BC")]
	[Address(RVA = "0x2841A38", Offset = "0x2841A38", VA = "0x2841A38")]
	private void ChannelSelectHandler(object[] args)
	{
	}

	[Token(Token = "0x600A2BD")]
	[Address(RVA = "0x2841C58", Offset = "0x2841C58", VA = "0x2841C58")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600A2BE")]
	[Address(RVA = "0x2841CF4", Offset = "0x2841CF4", VA = "0x2841CF4")]
	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	[Token(Token = "0x600A2BF")]
	[Address(RVA = "0x2841CFC", Offset = "0x2841CFC", VA = "0x2841CFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A2C0")]
	[Address(RVA = "0x2841D04", Offset = "0x2841D04", VA = "0x2841D04")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
