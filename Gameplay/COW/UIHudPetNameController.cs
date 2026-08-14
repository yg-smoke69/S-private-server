using COW.GamePlay;
using COW.HUD;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027F4")]
internal class UIHudPetNameController : UIHudEntityPosControllerBase
{
	[Token(Token = "0x400F68A")]
	[FieldOffset(Offset = "0x84")]
	private UIHudPetNameView m_View;

	[Token(Token = "0x400F68B")]
	[FieldOffset(Offset = "0x88")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x400F68C")]
	[FieldOffset(Offset = "0xA0")]
	private bool m_ShowForRole;

	[Token(Token = "0x400F68D")]
	[FieldOffset(Offset = "0xA1")]
	private bool m_PetShowing;

	[Token(Token = "0x600F80D")]
	[Address(RVA = "0x184DAA4", Offset = "0x184DAA4", VA = "0x184DAA4")]
	public UIHudPetNameController()
	{
	}

	[Token(Token = "0x600F80E")]
	[Address(RVA = "0x184DAAC", Offset = "0x184DAAC", VA = "0x184DAAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F80F")]
	[Address(RVA = "0x184DB54", Offset = "0x184DB54", VA = "0x184DB54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F810")]
	[Address(RVA = "0x184DC2C", Offset = "0x184DC2C", VA = "0x184DC2C", Slot = "32")]
	protected override void OnRegisterEvents()
	{
	}

	[Token(Token = "0x600F811")]
	[Address(RVA = "0x184DE98", Offset = "0x184DE98", VA = "0x184DE98", Slot = "33")]
	protected override void OnUnRegisterEvents()
	{
	}

	[Token(Token = "0x600F812")]
	[Address(RVA = "0x184E104", Offset = "0x184E104", VA = "0x184E104", Slot = "34")]
	public override void BindTarget(Entity e)
	{
	}

	[Token(Token = "0x600F813")]
	[Address(RVA = "0x184E460", Offset = "0x184E460", VA = "0x184E460", Slot = "38")]
	protected override Vector3 GetRefPos(Entity e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F814")]
	[Address(RVA = "0x184E608", Offset = "0x184E608", VA = "0x184E608", Slot = "31")]
	protected override void UpdateTargetPlayer()
	{
	}

	[Token(Token = "0x600F815")]
	[Address(RVA = "0x184E674", Offset = "0x184E674", VA = "0x184E674")]
	private void UpdateHideForRole()
	{
	}

	[Token(Token = "0x600F816")]
	[Address(RVA = "0x184E924", Offset = "0x184E924", VA = "0x184E924")]
	private void OnObserverChange(object[] data)
	{
	}

	[Token(Token = "0x600F817")]
	[Address(RVA = "0x184E9A8", Offset = "0x184E9A8", VA = "0x184E9A8")]
	private void OnPetDelete(object[] data)
	{
	}

	[Token(Token = "0x600F818")]
	[Address(RVA = "0x184EB18", Offset = "0x184EB18", VA = "0x184EB18")]
	private void OnPetShowHide(object[] data)
	{
	}

	[Token(Token = "0x600F819")]
	[Address(RVA = "0x184E40C", Offset = "0x184E40C", VA = "0x184E40C")]
	private void UpdateColor()
	{
	}

	[Token(Token = "0x600F81A")]
	[Address(RVA = "0x184ECB8", Offset = "0x184ECB8", VA = "0x184ECB8")]
	private void UpdateColor(bool isLocalPlayer)
	{
	}

	[Token(Token = "0x600F81B")]
	[Address(RVA = "0x184E388", Offset = "0x184E388", VA = "0x184E388")]
	private void UpdateShowHide()
	{
	}

	[Token(Token = "0x600F81C")]
	[Address(RVA = "0x184EDBC", Offset = "0x184EDBC", VA = "0x184EDBC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F81D")]
	[Address(RVA = "0x184EDC4", Offset = "0x184EDC4", VA = "0x184EDC4")]
	public void _003C_003EiFixBaseProxy_OnRegisterEvents()
	{
	}

	[Token(Token = "0x600F81E")]
	[Address(RVA = "0x184EDCC", Offset = "0x184EDCC", VA = "0x184EDCC")]
	public void _003C_003EiFixBaseProxy_OnUnRegisterEvents()
	{
	}

	[Token(Token = "0x600F81F")]
	[Address(RVA = "0x184EDD4", Offset = "0x184EDD4", VA = "0x184EDD4")]
	public void _003C_003EiFixBaseProxy_BindTarget(Entity P0)
	{
	}

	[Token(Token = "0x600F820")]
	[Address(RVA = "0x184EDDC", Offset = "0x184EDDC", VA = "0x184EDDC")]
	public Vector3 _003C_003EiFixBaseProxy_GetRefPos(Entity P0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600F821")]
	[Address(RVA = "0x184EDF0", Offset = "0x184EDF0", VA = "0x184EDF0")]
	public void _003C_003EiFixBaseProxy_UpdateTargetPlayer()
	{
	}
}
