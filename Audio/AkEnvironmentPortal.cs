using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003E19")]
public class AkEnvironmentPortal : MonoBehaviour
{
	[Token(Token = "0x401A4CB")]
	public const int MAX_ENVIRONMENTS_PER_PORTAL = 2;

	[Token(Token = "0x401A4CC")]
	[FieldOffset(Offset = "0xC")]
	public Vector3 axis;

	[Token(Token = "0x401A4CD")]
	[FieldOffset(Offset = "0x18")]
	public AkEnvironment[] environments;

	[Token(Token = "0x401A4CE")]
	[FieldOffset(Offset = "0x1C")]
	private BoxCollider m_BoxCollider;

	[Token(Token = "0x17001B80")]
	private BoxCollider BoxCollider
	{
		[Token(Token = "0x60193FD")]
		[Address(RVA = "0x35D5920", Offset = "0x35D5920", VA = "0x35D5920")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B81")]
	public bool EnvironmentsShareAuxBus
	{
		[Token(Token = "0x60193FE")]
		[Address(RVA = "0x35D59D0", Offset = "0x35D59D0", VA = "0x35D59D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60193FC")]
	[Address(RVA = "0x35D5860", Offset = "0x35D5860", VA = "0x35D5860")]
	public AkEnvironmentPortal()
	{
	}

	[Token(Token = "0x60193FF")]
	[Address(RVA = "0x35D5CC0", Offset = "0x35D5CC0", VA = "0x35D5CC0")]
	public float GetAuxSendValueForPosition(Vector3 in_position, int index)
	{
		return default(float);
	}
}
