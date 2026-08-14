using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004111")]
public class MaskShaderController : MonoBehaviour
{
	[Token(Token = "0x401B53E")]
	[FieldOffset(Offset = "0xC")]
	private float wr;

	[Token(Token = "0x401B53F")]
	[FieldOffset(Offset = "0x10")]
	private float hr;

	[Token(Token = "0x401B540")]
	[FieldOffset(Offset = "0x14")]
	private float offX;

	[Token(Token = "0x401B541")]
	[FieldOffset(Offset = "0x18")]
	private float offY;

	[Token(Token = "0x401B542")]
	[FieldOffset(Offset = "0x1C")]
	private Texture2D tex;

	[Token(Token = "0x401B543")]
	[FieldOffset(Offset = "0x20")]
	public UIMaskEffectSprite comp;

	[Token(Token = "0x401B544")]
	[FieldOffset(Offset = "0x24")]
	private bool setmask;

	[Token(Token = "0x601A918")]
	[Address(RVA = "0x29683FC", Offset = "0x29683FC", VA = "0x29683FC")]
	public MaskShaderController()
	{
	}

	[Token(Token = "0x601A919")]
	[Address(RVA = "0x2968404", Offset = "0x2968404", VA = "0x2968404")]
	private void Awake()
	{
	}

	[Token(Token = "0x601A91A")]
	[Address(RVA = "0x296846C", Offset = "0x296846C", VA = "0x296846C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x601A91B")]
	[Address(RVA = "0x2968478", Offset = "0x2968478", VA = "0x2968478")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x601A91C")]
	[Address(RVA = "0x2968484", Offset = "0x2968484", VA = "0x2968484")]
	private void FixedUpdate()
	{
	}
}
