using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2000A5C")]
internal class GunTraceEffect : ReusableObject
{
	[Token(Token = "0x4005BD9")]
	[FieldOffset(Offset = "0x18")]
	public float DelayDestoryTime;

	[Token(Token = "0x4005BDA")]
	[FieldOffset(Offset = "0x1C")]
	public float Speed;

	[Token(Token = "0x4005BDB")]
	[FieldOffset(Offset = "0x20")]
	private float m_StartTime;

	[Token(Token = "0x4005BDC")]
	[FieldOffset(Offset = "0x24")]
	private Renderer m_Renderer;

	[Token(Token = "0x4005BDD")]
	[FieldOffset(Offset = "0x28")]
	private float m_BlendFactor;

	[Token(Token = "0x4005BDE")]
	[FieldOffset(Offset = "0x2C")]
	private Material m_material;

	[Token(Token = "0x600504F")]
	[Address(RVA = "0x32B842C", Offset = "0x32B842C", VA = "0x32B842C")]
	public GunTraceEffect()
	{
	}

	[Token(Token = "0x6005050")]
	[Address(RVA = "0x32B8448", Offset = "0x32B8448", VA = "0x32B8448")]
	private void Start()
	{
	}

	[Token(Token = "0x6005051")]
	[Address(RVA = "0x32B8558", Offset = "0x32B8558", VA = "0x32B8558", Slot = "4")]
	public override void Prepare()
	{
	}

	[Token(Token = "0x6005052")]
	[Address(RVA = "0x32B8584", Offset = "0x32B8584", VA = "0x32B8584")]
	private void Update()
	{
	}
}
