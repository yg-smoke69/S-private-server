using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000444")]
public class FullScreenAdapter : MonoBehaviour
{
	[Token(Token = "0x2000445")]
	public enum AdaptType
	{
		[Token(Token = "0x4003C3C")]
		Stretch,
		[Token(Token = "0x4003C3D")]
		Fit
	}

	[Token(Token = "0x4003C2E")]
	[FieldOffset(Offset = "0xC")]
	public Camera cam;

	[Token(Token = "0x4003C2F")]
	[FieldOffset(Offset = "0x10")]
	public AdaptType adaptType;

	[Token(Token = "0x4003C30")]
	[FieldOffset(Offset = "0x14")]
	public float zDis;

	[Token(Token = "0x4003C31")]
	[FieldOffset(Offset = "0x18")]
	public Vector2 scale;

	[Token(Token = "0x4003C32")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 offset;

	[Token(Token = "0x4003C33")]
	[FieldOffset(Offset = "0x28")]
	public bool isLocked;

	[Token(Token = "0x4003C34")]
	[FieldOffset(Offset = "0x2C")]
	private float m_lastFOV;

	[Token(Token = "0x4003C35")]
	[FieldOffset(Offset = "0x30")]
	private float m_lastAspect;

	[Token(Token = "0x4003C36")]
	[FieldOffset(Offset = "0x34")]
	private bool isInit;

	[Token(Token = "0x4003C37")]
	[FieldOffset(Offset = "0x38")]
	private Vector2 m_orginalScale;

	[Token(Token = "0x4003C38")]
	[FieldOffset(Offset = "0x40")]
	private float m_orginalFOV;

	[Token(Token = "0x4003C39")]
	private const float m_orginalAspect = 1.7777778f;

	[Token(Token = "0x4003C3A")]
	[FieldOffset(Offset = "0x44")]
	private Mesh m_planeMesh;

	[Token(Token = "0x6001557")]
	[Address(RVA = "0x26AFE38", Offset = "0x26AFE38", VA = "0x26AFE38")]
	public FullScreenAdapter()
	{
	}

	[Token(Token = "0x6001558")]
	[Address(RVA = "0x26AFF2C", Offset = "0x26AFF2C", VA = "0x26AFF2C")]
	private void Init()
	{
	}

	[Token(Token = "0x6001559")]
	[Address(RVA = "0x26B081C", Offset = "0x26B081C", VA = "0x26B081C")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600155A")]
	[Address(RVA = "0x26B0820", Offset = "0x26B0820", VA = "0x26B0820")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600155B")]
	[Address(RVA = "0x26B0830", Offset = "0x26B0830", VA = "0x26B0830")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600155C")]
	[Address(RVA = "0x26B083C", Offset = "0x26B083C", VA = "0x26B083C")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600155D")]
	[Address(RVA = "0x26B0128", Offset = "0x26B0128", VA = "0x26B0128")]
	public void AdaptCamera()
	{
	}
}
