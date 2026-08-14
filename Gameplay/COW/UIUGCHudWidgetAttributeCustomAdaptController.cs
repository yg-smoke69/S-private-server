using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002414")]
public class UIUGCHudWidgetAttributeCustomAdaptController : UIUGCHudWidgetAttributeController<Vector2Int>
{
	[Token(Token = "0x400E0C3")]
	[FieldOffset(Offset = "0x38")]
	private UIUGCHudWidgetAttributeCustomAdaptView m_View;

	[Token(Token = "0x170010FC")]
	public override Vector2Int AttributeData
	{
		[Token(Token = "0x600CBD7")]
		[Address(RVA = "0x2FF52E0", Offset = "0x2FF52E0", VA = "0x2FF52E0", Slot = "36")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2Int);
		}
		[Token(Token = "0x600CBD8")]
		[Address(RVA = "0x2FF534C", Offset = "0x2FF534C", VA = "0x2FF534C", Slot = "37")]
		set
		{
		}
	}

	[Token(Token = "0x600CBD4")]
	[Address(RVA = "0x2FF5180", Offset = "0x2FF5180", VA = "0x2FF5180")]
	public UIUGCHudWidgetAttributeCustomAdaptController()
	{
	}

	[Token(Token = "0x600CBD5")]
	[Address(RVA = "0x2FF51E4", Offset = "0x2FF51E4", VA = "0x2FF51E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CBD6")]
	[Address(RVA = "0x2FF5288", Offset = "0x2FF5288", VA = "0x2FF5288", Slot = "31")]
	protected override UIUGCHudWidgetAttributeEnum GetAttributeEnum()
	{
		return default(UIUGCHudWidgetAttributeEnum);
	}

	[Token(Token = "0x600CBD9")]
	[Address(RVA = "0x2FF5478", Offset = "0x2FF5478", VA = "0x2FF5478", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CBDA")]
	[Address(RVA = "0x2FF587C", Offset = "0x2FF587C", VA = "0x2FF587C", Slot = "38")]
	public override void InitAttribute(Vector2Int data)
	{
	}

	[Token(Token = "0x600CBDB")]
	[Address(RVA = "0x2FF5D1C", Offset = "0x2FF5D1C", VA = "0x2FF5D1C")]
	private void OnHorizontalValueChanged(int value)
	{
	}

	[Token(Token = "0x600CBDC")]
	[Address(RVA = "0x2FF5DF4", Offset = "0x2FF5DF4", VA = "0x2FF5DF4")]
	private void OnVerticalValueChanged(int value)
	{
	}

	[Token(Token = "0x600CBDD")]
	[Address(RVA = "0x2FF5A18", Offset = "0x2FF5A18", VA = "0x2FF5A18")]
	private void UpdateAnchorIcon(int x, int y)
	{
	}

	[Token(Token = "0x600CBDE")]
	[Address(RVA = "0x2FF5ECC", Offset = "0x2FF5ECC", VA = "0x2FF5ECC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
