using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200208F")]
public class UICupMatchTeamProfileOtherController : UICupMatchTeamProfileController, _Attribute
{
	[Token(Token = "0x400CC18")]
	[FieldOffset(Offset = "0x48")]
	private ulong m_TeamID;

	[Token(Token = "0x400CC19")]
	[FieldOffset(Offset = "0x50")]
	private CupTeamInfo m_TeamInfo;

	[Token(Token = "0x400CC1A")]
	[FieldOffset(Offset = "0x54")]
	private List<UIModelCupMatch.AccountInfoBasicWithCupInfo> m_TeamMemberInfo;

	[Token(Token = "0x400CC1B")]
	[FieldOffset(Offset = "0x58")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x600A794")]
	[Address(RVA = "0x11E0F38", Offset = "0x11E0F38", VA = "0x11E0F38")]
	public UICupMatchTeamProfileOtherController()
	{
	}

	[Token(Token = "0x600A795")]
	[Address(RVA = "0x11E0F3C", Offset = "0x11E0F3C", VA = "0x11E0F3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A796")]
	[Address(RVA = "0x11E0F90", Offset = "0x11E0F90", VA = "0x11E0F90", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A797")]
	[Address(RVA = "0x11E114C", Offset = "0x11E114C", VA = "0x11E114C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A798")]
	[Address(RVA = "0x11E11D4", Offset = "0x11E11D4", VA = "0x11E11D4")]
	public void SetViewData(uint teamID, int key)
	{
	}

	[Token(Token = "0x600A799")]
	[Address(RVA = "0x11E1344", Offset = "0x11E1344", VA = "0x11E1344")]
	private void UpdateTeamInfoView()
	{
	}

	[Token(Token = "0x600A79A")]
	[Address(RVA = "0x11E13D8", Offset = "0x11E13D8", VA = "0x11E13D8")]
	private void UpdateTeamMemberView()
	{
	}

	[Token(Token = "0x600A79B")]
	[Address(RVA = "0x11E1720", Offset = "0x11E1720", VA = "0x11E1720")]
	public void SetBtnStatus()
	{
	}

	[Token(Token = "0x600A79C")]
	[Address(RVA = "0x11E18B8", Offset = "0x11E18B8", VA = "0x11E18B8")]
	public void ShowMembers()
	{
	}

	[Token(Token = "0x600A79D")]
	[Address(RVA = "0x11E1260", Offset = "0x11E1260", VA = "0x11E1260")]
	private void RequestData()
	{
	}

	[Token(Token = "0x600A79E")]
	[Address(RVA = "0x11E1938", Offset = "0x11E1938", VA = "0x11E1938", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A79F")]
	[Address(RVA = "0x11E1C30", Offset = "0x11E1C30", VA = "0x11E1C30", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A7A0")]
	[Address(RVA = "0x11E1CC4", Offset = "0x11E1CC4", VA = "0x11E1CC4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A7A1")]
	[Address(RVA = "0x11E1CC8", Offset = "0x11E1CC8", VA = "0x11E1CC8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
