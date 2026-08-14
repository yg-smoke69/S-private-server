using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007A8")]
public class AnimationDelay : MonoBehaviour
{
	[Token(Token = "0x4004F08")]
	[FieldOffset(Offset = "0xC")]
	public float delayTime;

	[Token(Token = "0x4004F09")]
	[FieldOffset(Offset = "0x10")]
	private bool isDelayCallBack;

	[Token(Token = "0x60030D6")]
	[Address(RVA = "0x2ECB7E0", Offset = "0x2ECB7E0", VA = "0x2ECB7E0")]
	public AnimationDelay()
	{
	}

	[Token(Token = "0x60030D7")]
	[Address(RVA = "0x2ECB7F0", Offset = "0x2ECB7F0", VA = "0x2ECB7F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60030D8")]
	[Address(RVA = "0x2ECB8A0", Offset = "0x2ECB8A0", VA = "0x2ECB8A0")]
	private void DelayFunc()
	{
	}
}
