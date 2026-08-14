using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003B60")]
public class HangCollider : MonoBehaviour
{
	[Token(Token = "0x40194B5")]
	[FieldOffset(Offset = "0xC")]
	protected HangManager script_HangManager;

	[Token(Token = "0x6017A41")]
	[Address(RVA = "0x350D2E0", Offset = "0x350D2E0", VA = "0x350D2E0")]
	public HangCollider()
	{
	}

	[Token(Token = "0x6017A42")]
	[Address(RVA = "0x350D2E8", Offset = "0x350D2E8", VA = "0x350D2E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6017A43")]
	[Address(RVA = "0x350D4D0", Offset = "0x350D4D0", VA = "0x350D4D0", Slot = "4")]
	public virtual HangColliderType GetColliderType()
	{
		return default(HangColliderType);
	}
}
