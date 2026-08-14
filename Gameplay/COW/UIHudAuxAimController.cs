using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026DE")]
internal class UIHudAuxAimController : UIHudButtonBaseController
{
	[Token(Token = "0x400F006")]
	[FieldOffset(Offset = "0x2C")]
	private UIHudAuxAimView m_View;

	[Token(Token = "0x400F007")]
	[FieldOffset(Offset = "0x30")]
	private bool m_HasRegistedButton;

	[Token(Token = "0x400F008")]
	[FieldOffset(Offset = "0x34")]
	private float m_BGRangeRadius;

	[Token(Token = "0x400F009")]
	[FieldOffset(Offset = "0x38")]
	private string m_strButtonAction;

	[Token(Token = "0x400F00A")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_ShowByConfig;

	[Token(Token = "0x400F00B")]
	[FieldOffset(Offset = "0x3D")]
	private bool m_ShowByPlayerState;

	[Token(Token = "0x400F00C")]
	[FieldOffset(Offset = "0x40")]
	private Vector3 m_StartPos;

	[Token(Token = "0x400F00D")]
	[FieldOffset(Offset = "0x4C")]
	private float m_DirectionVal;

	[Token(Token = "0x600EB48")]
	[Address(RVA = "0x170D07C", Offset = "0x170D07C", VA = "0x170D07C")]
	public UIHudAuxAimController()
	{
	}

	[Token(Token = "0x600EB49")]
	[Address(RVA = "0x170D0F4", Offset = "0x170D0F4", VA = "0x170D0F4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB4A")]
	[Address(RVA = "0x170D198", Offset = "0x170D198", VA = "0x170D198", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB4B")]
	[Address(RVA = "0x170D4AC", Offset = "0x170D4AC", VA = "0x170D4AC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EB4C")]
	[Address(RVA = "0x170D780", Offset = "0x170D780", VA = "0x170D780", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600EB4D")]
	[Address(RVA = "0x170DD34", Offset = "0x170DD34", VA = "0x170DD34", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EB4E")]
	[Address(RVA = "0x170D7FC", Offset = "0x170D7FC", VA = "0x170D7FC")]
	private void UpdateAxisTouchingThroughArea()
	{
	}

	[Token(Token = "0x600EB4F")]
	[Address(RVA = "0x170DF14", Offset = "0x170DF14", VA = "0x170DF14")]
	private void OnLocalPlayerAdd(object[] data)
	{
	}

	[Token(Token = "0x600EB50")]
	[Address(RVA = "0x170DF7C", Offset = "0x170DF7C", VA = "0x170DF7C")]
	private void Update()
	{
	}

	[Token(Token = "0x600EB51")]
	[Address(RVA = "0x170E7F0", Offset = "0x170E7F0", VA = "0x170E7F0", Slot = "31")]
	protected override void OnBtnDown()
	{
	}

	[Token(Token = "0x600EB52")]
	[Address(RVA = "0x170E854", Offset = "0x170E854", VA = "0x170E854", Slot = "32")]
	protected override void OnBtnUp()
	{
	}

	[Token(Token = "0x600EB53")]
	[Address(RVA = "0x170E8B8", Offset = "0x170E8B8", VA = "0x170E8B8", Slot = "36")]
	protected override string GetMappingName()
	{
		return null;
	}

	[Token(Token = "0x600EB54")]
	[Address(RVA = "0x170E748", Offset = "0x170E748", VA = "0x170E748")]
	private void UpdateBtnPushStatus(bool down)
	{
	}

	[Token(Token = "0x600EB55")]
	[Address(RVA = "0x170E910", Offset = "0x170E910", VA = "0x170E910")]
	private void OnHudSettingChanged(object[] param)
	{
	}

	[Token(Token = "0x600EB56")]
	[Address(RVA = "0x170E978", Offset = "0x170E978", VA = "0x170E978")]
	private void OnHudSettingChange(object[] param)
	{
	}

	[Token(Token = "0x600EB57")]
	[Address(RVA = "0x170DBD8", Offset = "0x170DBD8", VA = "0x170DBD8")]
	private void UpdateShowConfig()
	{
	}

	[Token(Token = "0x600EB58")]
	[Address(RVA = "0x170DCA4", Offset = "0x170DCA4", VA = "0x170DCA4")]
	private void UpdateVisibility()
	{
	}

	[Token(Token = "0x600EB59")]
	[Address(RVA = "0x170EAF4", Offset = "0x170EAF4", VA = "0x170EAF4")]
	private void OnShowSelf(object[] param)
	{
	}

	[Token(Token = "0x600EB5A")]
	[Address(RVA = "0x170EBE4", Offset = "0x170EBE4", VA = "0x170EBE4")]
	private void OnAimingEnemy(object[] data)
	{
	}

	[Token(Token = "0x600EB5B")]
	[Address(RVA = "0x170ED40", Offset = "0x170ED40", VA = "0x170ED40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB5C")]
	[Address(RVA = "0x170ED48", Offset = "0x170ED48", VA = "0x170ED48")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600EB5D")]
	[Address(RVA = "0x170ED50", Offset = "0x170ED50", VA = "0x170ED50")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600EB5E")]
	[Address(RVA = "0x170ED58", Offset = "0x170ED58", VA = "0x170ED58")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EB5F")]
	[Address(RVA = "0x170ED60", Offset = "0x170ED60", VA = "0x170ED60")]
	public void _003C_003EiFixBaseProxy_OnBtnDown()
	{
	}

	[Token(Token = "0x600EB60")]
	[Address(RVA = "0x170ED68", Offset = "0x170ED68", VA = "0x170ED68")]
	public void _003C_003EiFixBaseProxy_OnBtnUp()
	{
	}
}
