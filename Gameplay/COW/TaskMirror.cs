using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AD4")]
public class TaskMirror : BaseTask
{
	[Token(Token = "0x4018FE8")]
	[FieldOffset(Offset = "0x48")]
	public Camera camera;

	[Token(Token = "0x4018FE9")]
	[FieldOffset(Offset = "0x4C")]
	public UITexture texture;

	[Token(Token = "0x4018FEA")]
	[FieldOffset(Offset = "0x50")]
	public float radius;

	[Token(Token = "0x4018FEB")]
	[FieldOffset(Offset = "0x54")]
	public float successRate;

	[Token(Token = "0x4018FEC")]
	[FieldOffset(Offset = "0x58")]
	private Color32[] m_TarColor;

	[Token(Token = "0x4018FED")]
	[FieldOffset(Offset = "0x5C")]
	private bool[] m_BMask;

	[Token(Token = "0x4018FEE")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsDirty;

	[Token(Token = "0x4018FEF")]
	[FieldOffset(Offset = "0x64")]
	private float m_Radius2;

	[Token(Token = "0x4018FF0")]
	[FieldOffset(Offset = "0x68")]
	private int m_Count;

	[Token(Token = "0x4018FF1")]
	[FieldOffset(Offset = "0x6C")]
	private bool m_IsComplete;

	[Token(Token = "0x4018FF2")]
	[FieldOffset(Offset = "0x70")]
	private Texture2D m_mask;

	[Token(Token = "0x60174B3")]
	[Address(RVA = "0x2898A98", Offset = "0x2898A98", VA = "0x2898A98")]
	public TaskMirror()
	{
	}

	[Token(Token = "0x60174B4")]
	[Address(RVA = "0x2898AA0", Offset = "0x2898AA0", VA = "0x2898AA0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60174B5")]
	[Address(RVA = "0x2899020", Offset = "0x2899020", VA = "0x2899020")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60174B6")]
	[Address(RVA = "0x28992E4", Offset = "0x28992E4", VA = "0x28992E4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60174B7")]
	[Address(RVA = "0x2899628", Offset = "0x2899628", VA = "0x2899628")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x60174B8")]
	[Address(RVA = "0x2899AA8", Offset = "0x2899AA8", VA = "0x2899AA8")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x60174B9")]
	[Address(RVA = "0x28996EC", Offset = "0x28996EC", VA = "0x28996EC")]
	private void MaskDrawLine(Vector2 pos1, Vector2 pos2, float radius)
	{
	}

	[Token(Token = "0x60174BA")]
	[Address(RVA = "0x2899C44", Offset = "0x2899C44", VA = "0x2899C44")]
	private void MaskDrawCircle(Vector2 localPos, float radius)
	{
	}

	[Token(Token = "0x60174BB")]
	[Address(RVA = "0x2899F10", Offset = "0x2899F10", VA = "0x2899F10")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60174BC")]
	[Address(RVA = "0x289A22C", Offset = "0x289A22C", VA = "0x289A22C")]
	private void CheckComplete()
	{
	}
}
