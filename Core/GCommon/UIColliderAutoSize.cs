using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004132")]
public class UIColliderAutoSize : MonoBehaviour
{
	[Token(Token = "0x401B5F7")]
	[FieldOffset(Offset = "0xC")]
	public UISprite target;

	[Token(Token = "0x401B5F8")]
	[FieldOffset(Offset = "0x10")]
	private BoxCollider collider;

	[Token(Token = "0x601AA4D")]
	[Address(RVA = "0x2C9E1D8", Offset = "0x2C9E1D8", VA = "0x2C9E1D8")]
	public UIColliderAutoSize()
	{
	}

	[Token(Token = "0x601AA4E")]
	[Address(RVA = "0x2C9E1E0", Offset = "0x2C9E1E0", VA = "0x2C9E1E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AA4F")]
	[Address(RVA = "0x2C9E3D8", Offset = "0x2C9E3D8", VA = "0x2C9E3D8")]
	private void Start()
	{
	}

	[Token(Token = "0x601AA50")]
	[Address(RVA = "0x2C9E3DC", Offset = "0x2C9E3DC", VA = "0x2C9E3DC")]
	private void Update()
	{
	}

	[Token(Token = "0x601AA51")]
	[Address(RVA = "0x2C9E3E0", Offset = "0x2C9E3E0", VA = "0x2C9E3E0")]
	private void OnTargetChange()
	{
	}
}
