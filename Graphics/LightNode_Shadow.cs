using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003F9E")]
public class LightNode_Shadow : PlanarShadowNode
{
	[Token(Token = "0x2003F9F")]
	public delegate void LightNodeActiveChanged(LightNode_Shadow node, bool active);

	[Token(Token = "0x401ACDC")]
	[FieldOffset(Offset = "0xC")]
	public Light m_light;

	[Token(Token = "0x401ACDD")]
	[FieldOffset(Offset = "0x10")]
	public LightNodeActiveChanged OnLightNodeChanged;

	[Token(Token = "0x17001C48")]
	public Light light
	{
		[Token(Token = "0x6019E25")]
		[Address(RVA = "0x3116300", Offset = "0x3116300", VA = "0x3116300")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019E26")]
		[Address(RVA = "0x3116308", Offset = "0x3116308", VA = "0x3116308")]
		set
		{
		}
	}

	[Token(Token = "0x6019E24")]
	[Address(RVA = "0x31162F8", Offset = "0x31162F8", VA = "0x31162F8")]
	public LightNode_Shadow()
	{
	}

	[Token(Token = "0x6019E27")]
	[Address(RVA = "0x31163E8", Offset = "0x31163E8", VA = "0x31163E8", Slot = "6")]
	protected override void OnEnableDisable(bool isActive)
	{
	}

	[Token(Token = "0x6019E28")]
	[Address(RVA = "0x3116310", Offset = "0x3116310", VA = "0x3116310")]
	private void Init()
	{
	}

	[Token(Token = "0x6019E29")]
	[Address(RVA = "0x31167E0", Offset = "0x31167E0", VA = "0x31167E0", Slot = "7")]
	protected override void OnDestroy()
	{
	}
}
