using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CD9")]
internal class InGameClickEffect : MonoSingleton<InGameClickEffect>
{
	[Token(Token = "0x4011192")]
	[FieldOffset(Offset = "0xC")]
	public Animator m_ClickEffect;

	[Token(Token = "0x4011193")]
	[FieldOffset(Offset = "0x10")]
	private bool m_Registered;

	[Token(Token = "0x6012C4C")]
	[Address(RVA = "0x2C71A44", Offset = "0x2C71A44", VA = "0x2C71A44")]
	public InGameClickEffect()
	{
	}

	[Token(Token = "0x6012C4D")]
	[Address(RVA = "0x2C71AD4", Offset = "0x2C71AD4", VA = "0x2C71AD4")]
	private void Start()
	{
	}

	[Token(Token = "0x6012C4E")]
	[Address(RVA = "0x2C71B28", Offset = "0x2C71B28", VA = "0x2C71B28", Slot = "6")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x6012C4F")]
	[Address(RVA = "0x2C71D48", Offset = "0x2C71D48", VA = "0x2C71D48", Slot = "5")]
	public override void Init()
	{
	}

	[Token(Token = "0x6012C50")]
	[Address(RVA = "0x2C71E80", Offset = "0x2C71E80", VA = "0x2C71E80")]
	public void Show()
	{
	}

	[Token(Token = "0x6012C51")]
	[Address(RVA = "0x2C71FA0", Offset = "0x2C71FA0", VA = "0x2C71FA0")]
	public void Hide()
	{
	}

	[Token(Token = "0x6012C52")]
	[Address(RVA = "0x2C720C0", Offset = "0x2C720C0", VA = "0x2C720C0")]
	public void RegisterUICameraCustomInput()
	{
	}

	[Token(Token = "0x6012C53")]
	[Address(RVA = "0x2C71B88", Offset = "0x2C71B88", VA = "0x2C71B88")]
	public void UnRegisterUICameraCustomInput()
	{
	}

	[Token(Token = "0x6012C54")]
	[Address(RVA = "0x2C7228C", Offset = "0x2C7228C", VA = "0x2C7228C")]
	private void OnUICameraCustomInput()
	{
	}

	[Token(Token = "0x6012C55")]
	[Address(RVA = "0x2C725F8", Offset = "0x2C725F8", VA = "0x2C725F8")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	[Token(Token = "0x6012C56")]
	[Address(RVA = "0x2C725FC", Offset = "0x2C725FC", VA = "0x2C725FC")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
