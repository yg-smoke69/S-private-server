using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20027F5")]
public class UIHudPetSkillBufferController : UIBaseController
{
	[Token(Token = "0x400F68E")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPetSkillBufferView m_View;

	[Token(Token = "0x400F68F")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_PetSkillID;

	[Token(Token = "0x400F690")]
	[FieldOffset(Offset = "0x30")]
	private uint m_PetSkillLevel;

	[Token(Token = "0x400F691")]
	[FieldOffset(Offset = "0x34")]
	private PetSkillLevelData m_SkillLevelData;

	[Token(Token = "0x400F692")]
	[FieldOffset(Offset = "0x38")]
	private Action m_OnCloseCallback;

	[Token(Token = "0x400F693")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_HasCD;

	[Token(Token = "0x400F694")]
	[FieldOffset(Offset = "0x40")]
	private float m_lastTime;

	[Token(Token = "0x400F695")]
	[FieldOffset(Offset = "0x44")]
	private float m_CDTime;

	[Token(Token = "0x600F822")]
	[Address(RVA = "0x1851B1C", Offset = "0x1851B1C", VA = "0x1851B1C")]
	public UIHudPetSkillBufferController()
	{
	}

	[Token(Token = "0x600F823")]
	[Address(RVA = "0x1851BAC", Offset = "0x1851BAC", VA = "0x1851BAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F824")]
	[Address(RVA = "0x1851C54", Offset = "0x1851C54", VA = "0x1851C54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F825")]
	[Address(RVA = "0x1851E44", Offset = "0x1851E44", VA = "0x1851E44", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F826")]
	[Address(RVA = "0x1851F78", Offset = "0x1851F78", VA = "0x1851F78")]
	public void SkillStart(uint petID, uint petSkillID, uint petSkillLevel, Action closeCallback)
	{
	}

	[Token(Token = "0x600F827")]
	[Address(RVA = "0x1852538", Offset = "0x1852538", VA = "0x1852538")]
	private void OnPetSkillEnd(object[] param)
	{
	}

	[Token(Token = "0x600F828")]
	[Address(RVA = "0x1852618", Offset = "0x1852618", VA = "0x1852618")]
	private void Update()
	{
	}

	[Token(Token = "0x600F829")]
	[Address(RVA = "0x18525A0", Offset = "0x18525A0", VA = "0x18525A0")]
	private void CloseUI()
	{
	}

	[Token(Token = "0x600F82A")]
	[Address(RVA = "0x185290C", Offset = "0x185290C", VA = "0x185290C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F82B")]
	[Address(RVA = "0x1852914", Offset = "0x1852914", VA = "0x1852914")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
