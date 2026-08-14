using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002522")]
public class UIChoose1From3ItemController : UIBaseController
{
	[Token(Token = "0x400E649")]
	[FieldOffset(Offset = "0x28")]
	private UIChoose1From3ItemView m_View;

	[Token(Token = "0x400E64A")]
	[FieldOffset(Offset = "0x2C")]
	private Action<OptionalBundleShowData> m_OnClickItem;

	[Token(Token = "0x400E64B")]
	[FieldOffset(Offset = "0x30")]
	private OptionalBundleShowData m_Data;

	[Token(Token = "0x400E64C")]
	[FieldOffset(Offset = "0x34")]
	private bool m_HasRecharge;

	[Token(Token = "0x400E64D")]
	[FieldOffset(Offset = "0x38")]
	private BaseItemInfo m_Info;

	[Token(Token = "0x600D7DD")]
	[Address(RVA = "0x208CDD8", Offset = "0x208CDD8", VA = "0x208CDD8")]
	public UIChoose1From3ItemController()
	{
	}

	[Token(Token = "0x600D7DE")]
	[Address(RVA = "0x208CE5C", Offset = "0x208CE5C", VA = "0x208CE5C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D7DF")]
	[Address(RVA = "0x208CF00", Offset = "0x208CF00", VA = "0x208CF00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D7E0")]
	[Address(RVA = "0x208BFB8", Offset = "0x208BFB8", VA = "0x208BFB8")]
	public void SetData(OptionalBundleShowData data, bool hasRecharge, Action<OptionalBundleShowData> onClickItem)
	{
	}

	[Token(Token = "0x600D7E1")]
	[Address(RVA = "0x208C550", Offset = "0x208C550", VA = "0x208C550")]
	public void ShowSelect(bool value)
	{
	}

	[Token(Token = "0x600D7E2")]
	[Address(RVA = "0x208D0F0", Offset = "0x208D0F0", VA = "0x208D0F0")]
	public void OnClickItem()
	{
	}

	[Token(Token = "0x600D7E3")]
	[Address(RVA = "0x208D068", Offset = "0x208D068", VA = "0x208D068")]
	public void SetQualityBG()
	{
	}

	[Token(Token = "0x600D7E4")]
	[Address(RVA = "0x208D1B4", Offset = "0x208D1B4", VA = "0x208D1B4")]
	public static void SetQualityBG(int Quality, UISprite QualityBG)
	{
	}

	[Token(Token = "0x600D7E5")]
	[Address(RVA = "0x208D374", Offset = "0x208D374", VA = "0x208D374")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
