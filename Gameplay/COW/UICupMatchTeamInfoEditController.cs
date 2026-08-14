using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002082")]
public class UICupMatchTeamInfoEditController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400CBCC")]
	[FieldOffset(Offset = "0x48")]
	private NationFlagData m_SelectNationFlag;

	[Token(Token = "0x400CBCD")]
	[FieldOffset(Offset = "0x4C")]
	private HeadPicBaseInfo m_ClanAvatarInfo;

	[Token(Token = "0x400CBCE")]
	[FieldOffset(Offset = "0x50")]
	private BannerBaseInfo m_ClanBannerInfo;

	[Token(Token = "0x400CBCF")]
	[FieldOffset(Offset = "0x54")]
	private UICupMatchTeamCreateFormView m_View;

	[Token(Token = "0x400CBD0")]
	[FieldOffset(Offset = "0x58")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBD1")]
	[FieldOffset(Offset = "0x5C")]
	private UIModelCollection m_ModelCollection;

	[Token(Token = "0x400CBD2")]
	[FieldOffset(Offset = "0x60")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CBD3")]
	[FieldOffset(Offset = "0x64")]
	private List<uint> m_WaitModelPropIDs;

	[Token(Token = "0x400CBD4")]
	[FieldOffset(Offset = "0x68")]
	private bool m_HasErr;

	[Token(Token = "0x600A70A")]
	[Address(RVA = "0x2ABA4AC", Offset = "0x2ABA4AC", VA = "0x2ABA4AC")]
	public UICupMatchTeamInfoEditController()
	{
	}

	[Token(Token = "0x600A70B")]
	[Address(RVA = "0x2ABA538", Offset = "0x2ABA538", VA = "0x2ABA538")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A70C")]
	[Address(RVA = "0x2ABA5E0", Offset = "0x2ABA5E0", VA = "0x2ABA5E0", Slot = "33")]
	public override string CustomTitle()
	{
		return null;
	}

	[Token(Token = "0x600A70D")]
	[Address(RVA = "0x2ABA684", Offset = "0x2ABA684", VA = "0x2ABA684", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A70E")]
	[Address(RVA = "0x2ABAA34", Offset = "0x2ABAA34", VA = "0x2ABAA34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A70F")]
	[Address(RVA = "0x2ABAC5C", Offset = "0x2ABAC5C", VA = "0x2ABAC5C")]
	public void SetCupMatchKey(int key)
	{
	}

	[Token(Token = "0x600A710")]
	[Address(RVA = "0x2ABB358", Offset = "0x2ABB358", VA = "0x2ABB358")]
	private void Confirm()
	{
	}

	[Token(Token = "0x600A711")]
	[Address(RVA = "0x2ABBB14", Offset = "0x2ABBB14", VA = "0x2ABBB14")]
	private void SelectFlag()
	{
	}

	[Token(Token = "0x600A712")]
	[Address(RVA = "0x2ABBC24", Offset = "0x2ABBC24", VA = "0x2ABBC24")]
	private void SelectAvatar()
	{
	}

	[Token(Token = "0x600A713")]
	[Address(RVA = "0x2ABBD34", Offset = "0x2ABBD34", VA = "0x2ABBD34")]
	private void SelectBanner()
	{
	}

	[Token(Token = "0x600A714")]
	[Address(RVA = "0x2ABBE44", Offset = "0x2ABBE44", VA = "0x2ABBE44", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A715")]
	[Address(RVA = "0x2ABC2D0", Offset = "0x2ABC2D0", VA = "0x2ABC2D0", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A716")]
	[Address(RVA = "0x2ABC364", Offset = "0x2ABC364", VA = "0x2ABC364")]
	private void NationalFlagSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A717")]
	[Address(RVA = "0x2ABC4CC", Offset = "0x2ABC4CC", VA = "0x2ABC4CC")]
	private void ClanAvatarSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A718")]
	[Address(RVA = "0x2ABC650", Offset = "0x2ABC650", VA = "0x2ABC650")]
	private void ClanBannerSelectHander(object[] args)
	{
	}

	[Token(Token = "0x600A719")]
	[Address(RVA = "0x2ABC818", Offset = "0x2ABC818", VA = "0x2ABC818")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600A71A")]
	[Address(RVA = "0x2ABC8B4", Offset = "0x2ABC8B4", VA = "0x2ABC8B4")]
	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	[Token(Token = "0x600A71B")]
	[Address(RVA = "0x2ABC8BC", Offset = "0x2ABC8BC", VA = "0x2ABC8BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A71C")]
	[Address(RVA = "0x2ABC8C4", Offset = "0x2ABC8C4", VA = "0x2ABC8C4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
