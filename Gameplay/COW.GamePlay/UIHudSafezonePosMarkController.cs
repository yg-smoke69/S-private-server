using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2002840")]
public class UIHudSafezonePosMarkController : UIHudNameBaseController
{
	[Token(Token = "0x400F868")]
	[FieldOffset(Offset = "0x50")]
	private UIHudTutorialTargetGuideView NOJLDPLOCIH;

	[Token(Token = "0x400F869")]
	private const float IDJPOGLFMNB = 1f;

	[Token(Token = "0x400F86A")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 CLCJEABFEHG;

	[Token(Token = "0x400F86B")]
	[FieldOffset(Offset = "0x60")]
	private SafeZone NFFBCAEJPGM;

	[Token(Token = "0x400F86C")]
	[FieldOffset(Offset = "0x64")]
	private readonly Color NMMJJJGPGHD;

	[Token(Token = "0x600FB4B")]
	[Address(RVA = "0xF7A804", Offset = "0xF7A804", VA = "0xF7A804")]
	public UIHudSafezonePosMarkController()
	{
	}

	[Token(Token = "0x600FB4C")]
	[Address(RVA = "0xF7A8C4", Offset = "0xF7A8C4", VA = "0xF7A8C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB4D")]
	[Address(RVA = "0xF7A968", Offset = "0xF7A968", VA = "0xF7A968", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB4E")]
	[Address(RVA = "0xF7AD00", Offset = "0xF7AD00", VA = "0xF7AD00", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB4F")]
	[Address(RVA = "0xF7AD64", Offset = "0xF7AD64", VA = "0xF7AD64", Slot = "33")]
	protected override bool NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB50")]
	[Address(RVA = "0xF7ADBC", Offset = "0xF7ADBC", VA = "0xF7ADBC", Slot = "34")]
	protected override bool NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB51")]
	[Address(RVA = "0xF7AE14", Offset = "0xF7AE14", VA = "0xF7AE14", Slot = "31")]
	protected override Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FB52")]
	[Address(RVA = "0xF7AFCC", Offset = "0xF7AFCC", VA = "0xF7AFCC", Slot = "42")]
	protected override Vector2 GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600FB53")]
	[Address(RVA = "0xF7B054", Offset = "0xF7B054", VA = "0xF7B054", Slot = "35")]
	protected override bool NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB54")]
	[Address(RVA = "0xF7B0AC", Offset = "0xF7B0AC", VA = "0xF7B0AC")]
	public void BindPlayerAndWorldPosition(Vector3 ADHGNBHMANA)
	{
	}

	[Token(Token = "0x600FB55")]
	[Address(RVA = "0xF7B134", Offset = "0xF7B134", VA = "0xF7B134", Slot = "41")]
	protected override void UpdateNamePosition()
	{
	}

	[Token(Token = "0x600FB56")]
	[Address(RVA = "0xF7B40C", Offset = "0xF7B40C", VA = "0xF7B40C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FB57")]
	[Address(RVA = "0xF7B414", Offset = "0xF7B414", VA = "0xF7B414")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB58")]
	[Address(RVA = "0xF7B41C", Offset = "0xF7B41C", VA = "0xF7B41C")]
	public bool _003C_003EiFixBaseProxy_NeedKeepInScreen()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB59")]
	[Address(RVA = "0xF7B424", Offset = "0xF7B424", VA = "0xF7B424")]
	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB5A")]
	[Address(RVA = "0xF7B42C", Offset = "0xF7B42C", VA = "0xF7B42C")]
	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600FB5B")]
	[Address(RVA = "0xF7B440", Offset = "0xF7B440", VA = "0xF7B440")]
	public Vector2 _003C_003EiFixBaseProxy_GetWidgetBound()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x600FB5C")]
	[Address(RVA = "0xF7B454", Offset = "0xF7B454", VA = "0xF7B454")]
	public bool _003C_003EiFixBaseProxy_NeedShowDistance()
	{
		return default(bool);
	}

	[Token(Token = "0x600FB5D")]
	[Address(RVA = "0xF7B45C", Offset = "0xF7B45C", VA = "0xF7B45C")]
	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}
}
