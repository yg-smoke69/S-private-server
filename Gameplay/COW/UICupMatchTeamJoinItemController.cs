using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200208A")]
public class UICupMatchTeamJoinItemController : UIEasyListItemController, _Attribute
{
	[Token(Token = "0x400CBFB")]
	[FieldOffset(Offset = "0x38")]
	private UICupMatchTeamJoinItemView m_View;

	[Token(Token = "0x400CBFC")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CBFD")]
	[FieldOffset(Offset = "0x40")]
	private FriendAccountInfoWithCupTeamInfo m_AccountInfoWithCupTeamInfo;

	[Token(Token = "0x400CBFE")]
	[FieldOffset(Offset = "0x44")]
	private UICupMatchTeamJoinController m_Parent;

	[Token(Token = "0x400CBFF")]
	[FieldOffset(Offset = "0x48")]
	private int m_CupMatchKey;

	[Token(Token = "0x600A75C")]
	[Address(RVA = "0x2AC3228", Offset = "0x2AC3228", VA = "0x2AC3228")]
	public UICupMatchTeamJoinItemController()
	{
	}

	[Token(Token = "0x600A75D")]
	[Address(RVA = "0x2AC3230", Offset = "0x2AC3230", VA = "0x2AC3230")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A75E")]
	[Address(RVA = "0x2AC32D8", Offset = "0x2AC32D8", VA = "0x2AC32D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A75F")]
	[Address(RVA = "0x2AC353C", Offset = "0x2AC353C", VA = "0x2AC353C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A760")]
	[Address(RVA = "0x2AC08A8", Offset = "0x2AC08A8", VA = "0x2AC08A8")]
	public void SetCupMatchKey(int cupMatchKey)
	{
	}

	[Token(Token = "0x600A761")]
	[Address(RVA = "0x2AC35C4", Offset = "0x2AC35C4", VA = "0x2AC35C4", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600A762")]
	[Address(RVA = "0x2AC412C", Offset = "0x2AC412C", VA = "0x2AC412C")]
	private void LookOver()
	{
	}

	[Token(Token = "0x600A763")]
	[Address(RVA = "0x2AC4354", Offset = "0x2AC4354", VA = "0x2AC4354")]
	private void ApplyFor()
	{
	}

	[Token(Token = "0x600A764")]
	[Address(RVA = "0x2AC3C98", Offset = "0x2AC3C98", VA = "0x2AC3C98")]
	private void UpdateApplyButtonView()
	{
	}

	[Token(Token = "0x600A765")]
	[Address(RVA = "0x2AC45BC", Offset = "0x2AC45BC", VA = "0x2AC45BC", Slot = "37")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A766")]
	[Address(RVA = "0x2AC4950", Offset = "0x2AC4950", VA = "0x2AC4950", Slot = "38")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A767")]
	[Address(RVA = "0x2AC49E4", Offset = "0x2AC49E4", VA = "0x2AC49E4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A768")]
	[Address(RVA = "0x2AC49EC", Offset = "0x2AC49EC", VA = "0x2AC49EC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
