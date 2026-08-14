using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200278C")]
internal class UIHudInventoryTagController : UIBaseController
{
	[Token(Token = "0x400F431")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_Camera;

	[Token(Token = "0x400F432")]
	[FieldOffset(Offset = "0x2C")]
	private UICamera m_UICamera;

	[Token(Token = "0x400F433")]
	[FieldOffset(Offset = "0x30")]
	private float dist;

	[Token(Token = "0x400F434")]
	[FieldOffset(Offset = "0x34")]
	public string TagDesc;

	[Token(Token = "0x400F435")]
	[FieldOffset(Offset = "0x38")]
	public int MinLabelWidth;

	[Token(Token = "0x400F436")]
	[FieldOffset(Offset = "0x3C")]
	public int MaxLabelWidth;

	[Token(Token = "0x400F437")]
	[FieldOffset(Offset = "0x40")]
	public bool m_IsPressing;

	[Token(Token = "0x400F438")]
	[FieldOffset(Offset = "0x44")]
	private UIHudInventoryTagView m_View;

	[Token(Token = "0x600F35B")]
	[Address(RVA = "0x209D9F8", Offset = "0x209D9F8", VA = "0x209D9F8")]
	public UIHudInventoryTagController()
	{
	}

	[Token(Token = "0x600F35C")]
	[Address(RVA = "0x209DAD0", Offset = "0x209DAD0", VA = "0x209DAD0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F35D")]
	[Address(RVA = "0x209DB78", Offset = "0x209DB78", VA = "0x209DB78", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F35E")]
	[Address(RVA = "0x209DED8", Offset = "0x209DED8", VA = "0x209DED8")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x600F35F")]
	[Address(RVA = "0x209DF2C", Offset = "0x209DF2C", VA = "0x209DF2C")]
	public void OnReInit()
	{
	}

	[Token(Token = "0x600F360")]
	[Address(RVA = "0x209DF80", Offset = "0x209DF80", VA = "0x209DF80")]
	public void SetViewData(WeaponTagInfoData data)
	{
	}

	[Token(Token = "0x600F361")]
	[Address(RVA = "0x209E2EC", Offset = "0x209E2EC", VA = "0x209E2EC")]
	public UIButton GetBtnForGuide()
	{
		return null;
	}

	[Token(Token = "0x600F362")]
	[Address(RVA = "0x209E35C", Offset = "0x209E35C", VA = "0x209E35C")]
	public UIWidget GetWidgetForGuide()
	{
		return null;
	}

	[Token(Token = "0x600F363")]
	[Address(RVA = "0x209E3CC", Offset = "0x209E3CC", VA = "0x209E3CC")]
	public float GetTagLeftPosX()
	{
		return default(float);
	}

	[Token(Token = "0x600F364")]
	[Address(RVA = "0x209E4BC", Offset = "0x209E4BC", VA = "0x209E4BC")]
	private bool CheckPos(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F365")]
	[Address(RVA = "0x209E82C", Offset = "0x209E82C", VA = "0x209E82C")]
	private bool CheckPcTouch(Vector3 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x600F366")]
	[Address(RVA = "0x209E93C", Offset = "0x209E93C", VA = "0x209E93C")]
	private void OnPress()
	{
	}

	[Token(Token = "0x600F367")]
	[Address(RVA = "0x209E998", Offset = "0x209E998", VA = "0x209E998")]
	private void OnRelease()
	{
	}

	[Token(Token = "0x600F368")]
	[Address(RVA = "0x209E9F4", Offset = "0x209E9F4", VA = "0x209E9F4")]
	private void TryGetCameraComponent()
	{
	}

	[Token(Token = "0x600F369")]
	[Address(RVA = "0x209EB58", Offset = "0x209EB58", VA = "0x209EB58")]
	private void Update()
	{
	}

	[Token(Token = "0x600F36A")]
	[Address(RVA = "0x209EC84", Offset = "0x209EC84", VA = "0x209EC84")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
