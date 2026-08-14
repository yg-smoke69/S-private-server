using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200334B")]
internal class UIHudBombDropPosMarkController : UIHudNameBaseController
{
	[Token(Token = "0x40138AD")]
	[FieldOffset(Offset = "0x50")]
	private UIHudBombDropPosMarkView m_View;

	[Token(Token = "0x40138AE")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_BombPos;

	[Token(Token = "0x6015CC1")]
	[Address(RVA = "0x1E09A78", Offset = "0x1E09A78", VA = "0x1E09A78")]
	public UIHudBombDropPosMarkController()
	{
	}

	[Token(Token = "0x6015CC2")]
	[Address(RVA = "0x1E09B1C", Offset = "0x1E09B1C", VA = "0x1E09B1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CC3")]
	[Address(RVA = "0x1E09BC0", Offset = "0x1E09BC0", VA = "0x1E09BC0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CC4")]
	[Address(RVA = "0x1E09E90", Offset = "0x1E09E90", VA = "0x1E09E90", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6015CC5")]
	[Address(RVA = "0x1E0A094", Offset = "0x1E0A094", VA = "0x1E0A094")]
	private void OnBombPickupDrop(object[] data)
	{
	}

	[Token(Token = "0x6015CC6")]
	[Address(RVA = "0x1E0A35C", Offset = "0x1E0A35C", VA = "0x1E0A35C")]
	private void OnBombPickupGet(object[] data)
	{
	}

	[Token(Token = "0x6015CC7")]
	[Address(RVA = "0x1E0A3D0", Offset = "0x1E0A3D0", VA = "0x1E0A3D0", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6015CC8")]
	[Address(RVA = "0x1E0A4F4", Offset = "0x1E0A4F4", VA = "0x1E0A4F4", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6015CC9")]
	[Address(RVA = "0x1E0A54C", Offset = "0x1E0A54C", VA = "0x1E0A54C", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6015CCA")]
	[Address(RVA = "0x1E0A6F8", Offset = "0x1E0A6F8", VA = "0x1E0A6F8", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x6015CCB")]
	[Address(RVA = "0x1E0A750", Offset = "0x1E0A750", VA = "0x1E0A750")]
	private void OnODFactionChanged(object[] data)
	{
	}

	[Token(Token = "0x6015CCC")]
	[Address(RVA = "0x1E0A850", Offset = "0x1E0A850", VA = "0x1E0A850", Slot = "40")]
	protected override void LateUpdate()
	{
	}

	[Token(Token = "0x6015CCD")]
	[Address(RVA = "0x1E0A944", Offset = "0x1E0A944", VA = "0x1E0A944")]
	private void UpdateNameAlpha()
	{
	}

	[Token(Token = "0x6015CCE")]
	[Address(RVA = "0x1E0AE68", Offset = "0x1E0AE68", VA = "0x1E0AE68")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015CCF")]
	[Address(RVA = "0x1E0AE70", Offset = "0x1E0AE70", VA = "0x1E0AE70")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6015CD0")]
	[Address(RVA = "0x1E0AE78", Offset = "0x1E0AE78", VA = "0x1E0AE78")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6015CD1")]
	[Address(RVA = "0x1E0AE8C", Offset = "0x1E0AE8C", VA = "0x1E0AE8C")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x6015CD2")]
	[Address(RVA = "0x1E0AE94", Offset = "0x1E0AE94", VA = "0x1E0AE94")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6015CD3")]
	[Address(RVA = "0x1E0AEA8", Offset = "0x1E0AEA8", VA = "0x1E0AEA8")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x6015CD4")]
	[Address(RVA = "0x1E0AEB0", Offset = "0x1E0AEB0", VA = "0x1E0AEB0")]
	public void _003C_003EiFixBaseProxy_LateUpdate()
	{
	}
}
