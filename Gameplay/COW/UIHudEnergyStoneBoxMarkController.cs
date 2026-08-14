using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002738")]
public class UIHudEnergyStoneBoxMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F215")]
	[FieldOffset(Offset = "0x50")]
	private UIHudEnergyStoneBoxMarkView m_View;

	[Token(Token = "0x400F216")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 m_MarkPosition;

	[Token(Token = "0x600EF0A")]
	[Address(RVA = "0x1CE380C", Offset = "0x1CE380C", VA = "0x1CE380C")]
	public UIHudEnergyStoneBoxMarkController()
	{
	}

	[Token(Token = "0x600EF0B")]
	[Address(RVA = "0x1CE38B0", Offset = "0x1CE38B0", VA = "0x1CE38B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EF0C")]
	[Address(RVA = "0x1CE3958", Offset = "0x1CE3958", VA = "0x1CE3958", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EF0D")]
	[Address(RVA = "0x1CE3AB0", Offset = "0x1CE3AB0", VA = "0x1CE3AB0", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF0E")]
	[Address(RVA = "0x1CE3B08", Offset = "0x1CE3B08", VA = "0x1CE3B08", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF0F")]
	[Address(RVA = "0x1CE3B60", Offset = "0x1CE3B60", VA = "0x1CE3B60", Slot = "32")]
	protected override bool NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF10")]
	[Address(RVA = "0x1CE3BB8", Offset = "0x1CE3BB8", VA = "0x1CE3BB8", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF11")]
	[Address(RVA = "0x1CE3C28", Offset = "0x1CE3C28", VA = "0x1CE3C28", Slot = "38")]
	protected override bool KeepShowDownArrow()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF12")]
	[Address(RVA = "0x1CE3C80", Offset = "0x1CE3C80", VA = "0x1CE3C80", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600EF13")]
	[Address(RVA = "0x1CE3D08", Offset = "0x1CE3D08", VA = "0x1CE3D08")]
	public void SetMarkData(Vector3 position)
	{
	}

	[Token(Token = "0x600EF14")]
	[Address(RVA = "0x1CE3D90", Offset = "0x1CE3D90", VA = "0x1CE3D90")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EF15")]
	[Address(RVA = "0x1CE3D98", Offset = "0x1CE3D98", VA = "0x1CE3D98")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF16")]
	[Address(RVA = "0x1CE3DA0", Offset = "0x1CE3DA0", VA = "0x1CE3DA0")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF17")]
	[Address(RVA = "0x1CE3DA8", Offset = "0x1CE3DA8", VA = "0x1CE3DA8")]
	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF18")]
	[Address(RVA = "0x1CE3DB0", Offset = "0x1CE3DB0", VA = "0x1CE3DB0")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600EF19")]
	[Address(RVA = "0x1CE3DC4", Offset = "0x1CE3DC4", VA = "0x1CE3DC4")]
	public bool _003C_003EiFixBaseProxy_KeepShowDownArrow()
	{
		return default(bool);
	}

	[Token(Token = "0x600EF1A")]
	[Address(RVA = "0x1CE3DCC", Offset = "0x1CE3DCC", VA = "0x1CE3DCC")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}
}
