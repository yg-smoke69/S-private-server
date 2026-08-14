using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001EB1")]
public class UIDigitaluniverseBClothesMissionItemController : UIDigitaluniverseBMissionBaseController
{
	[Token(Token = "0x400C119")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsFirstGuideClicked;

	[Token(Token = "0x60094AF")]
	[Address(RVA = "0x2ACE278", Offset = "0x2ACE278", VA = "0x2ACE278")]
	public UIDigitaluniverseBClothesMissionItemController()
	{
	}

	[Token(Token = "0x60094B0")]
	[Address(RVA = "0x2ACE280", Offset = "0x2ACE280", VA = "0x2ACE280")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60094B1")]
	[Address(RVA = "0x2ACE328", Offset = "0x2ACE328", VA = "0x2ACE328")]
	public new void OnClaimAward()
	{
	}

	[Token(Token = "0x60094B2")]
	[Address(RVA = "0x2ACB7F4", Offset = "0x2ACB7F4", VA = "0x2ACB7F4")]
	public UIWidget GetBgWidget()
	{
		return null;
	}

	[Token(Token = "0x60094B3")]
	[Address(RVA = "0x2ACC0F0", Offset = "0x2ACC0F0", VA = "0x2ACC0F0")]
	public Vector3 ClaimBtnPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60094B4")]
	[Address(RVA = "0x2ACC57C", Offset = "0x2ACC57C", VA = "0x2ACC57C")]
	public bool IsFirstGuideBtnClicked()
	{
		return default(bool);
	}

	[Token(Token = "0x60094B5")]
	[Address(RVA = "0x2ACE4D4", Offset = "0x2ACE4D4", VA = "0x2ACE4D4", Slot = "31")]
	protected override void SetMaskState()
	{
	}

	[Token(Token = "0x60094B6")]
	[Address(RVA = "0x2ACE660", Offset = "0x2ACE660", VA = "0x2ACE660")]
	public void _003C_003EiFixBaseProxy_SetMaskState()
	{
	}
}
