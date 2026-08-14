using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FC5")]
public class PetAvatarInfoComponent : MonoBehaviour
{
	[Token(Token = "0x400C751")]
	[FieldOffset(Offset = "0xC")]
	public Animation animator;

	[Token(Token = "0x400C752")]
	[FieldOffset(Offset = "0x10")]
	public UIItemInputHandler AvatarInput;

	[Token(Token = "0x400C753")]
	[FieldOffset(Offset = "0x14")]
	public BoxCollider boxCollider;

	[Token(Token = "0x6009ED2")]
	[Address(RVA = "0x1BF9920", Offset = "0x1BF9920", VA = "0x1BF9920")]
	public PetAvatarInfoComponent()
	{
	}
}
