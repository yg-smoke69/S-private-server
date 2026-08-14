using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004149")]
public class UIGyroMove : MonoBehaviour
{
	[Token(Token = "0x401B654")]
	[FieldOffset(Offset = "0xC")]
	public bool m_EnableGyro;

	[Token(Token = "0x401B655")]
	[FieldOffset(Offset = "0x10")]
	public float m_MoveSpeed;

	[Token(Token = "0x401B656")]
	[FieldOffset(Offset = "0x14")]
	public float m_RebackSpeed;

	[Token(Token = "0x401B657")]
	[FieldOffset(Offset = "0x18")]
	public float m_XLimit;

	[Token(Token = "0x401B658")]
	[FieldOffset(Offset = "0x1C")]
	public float m_YLimit;

	[Token(Token = "0x401B659")]
	[FieldOffset(Offset = "0x20")]
	private Transform m_Transform;

	[Token(Token = "0x401B65A")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_OriginPosition;

	[Token(Token = "0x601AAD4")]
	[Address(RVA = "0x147CA9C", Offset = "0x147CA9C", VA = "0x147CA9C")]
	public UIGyroMove()
	{
	}

	[Token(Token = "0x601AAD5")]
	[Address(RVA = "0x147CAC4", Offset = "0x147CAC4", VA = "0x147CAC4")]
	private void Start()
	{
	}

	[Token(Token = "0x601AAD6")]
	[Address(RVA = "0x147CB18", Offset = "0x147CB18", VA = "0x147CB18")]
	public bool IsEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x601AAD7")]
	[Address(RVA = "0x147CBCC", Offset = "0x147CBCC", VA = "0x147CBCC")]
	public void EnableGyro(bool v)
	{
	}

	[Token(Token = "0x601AAD8")]
	[Address(RVA = "0x147CBD4", Offset = "0x147CBD4", VA = "0x147CBD4")]
	public void SetMoveSpeed(float speed)
	{
	}

	[Token(Token = "0x601AAD9")]
	[Address(RVA = "0x147CBDC", Offset = "0x147CBDC", VA = "0x147CBDC")]
	public float MoveSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x601AADA")]
	[Address(RVA = "0x147CBE4", Offset = "0x147CBE4", VA = "0x147CBE4")]
	public void SetRebackSpeed(float speed)
	{
	}

	[Token(Token = "0x601AADB")]
	[Address(RVA = "0x147CBEC", Offset = "0x147CBEC", VA = "0x147CBEC")]
	public float RebackSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x601AADC")]
	[Address(RVA = "0x147CBF4", Offset = "0x147CBF4", VA = "0x147CBF4")]
	public void SetXLimit(float limit)
	{
	}

	[Token(Token = "0x601AADD")]
	[Address(RVA = "0x147CBFC", Offset = "0x147CBFC", VA = "0x147CBFC")]
	public void SetYLimit(float limit)
	{
	}

	[Token(Token = "0x601AADE")]
	[Address(RVA = "0x147CC04", Offset = "0x147CC04", VA = "0x147CC04")]
	private void Update()
	{
	}
}
