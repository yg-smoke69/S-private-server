using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EA9")]
public class UIDigitaluniverseBActivityMissionItemController : UIDigitaluniverseBMissionBaseController
{
	[Token(Token = "0x400C0E4")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsFirstGuideClicked;

	[Token(Token = "0x6009457")]
	[Address(RVA = "0x2D99DEC", Offset = "0x2D99DEC", VA = "0x2D99DEC")]
	public UIDigitaluniverseBActivityMissionItemController()
	{
	}

	[Token(Token = "0x6009458")]
	[Address(RVA = "0x2D99DF4", Offset = "0x2D99DF4", VA = "0x2D99DF4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009459")]
	[Address(RVA = "0x2D99E9C", Offset = "0x2D99E9C", VA = "0x2D99E9C")]
	public new void OnClaimAward()
	{
	}

	[Token(Token = "0x600945A")]
	[Address(RVA = "0x2D97078", Offset = "0x2D97078", VA = "0x2D97078")]
	public UIWidget GetBgWidget()
	{
		return null;
	}

	[Token(Token = "0x600945B")]
	[Address(RVA = "0x2D97938", Offset = "0x2D97938", VA = "0x2D97938")]
	public Vector3 ClaimBtnPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600945C")]
	[Address(RVA = "0x2D97FF8", Offset = "0x2D97FF8", VA = "0x2D97FF8")]
	public bool IsFirstGuideBtnClicked()
	{
		return default(bool);
	}
}
