using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B1E")]
public class NPCAnimPlay : MonoBehaviour
{
	[Token(Token = "0x4005FE4")]
	[FieldOffset(Offset = "0xC")]
	public string AnimName;

	[Token(Token = "0x4005FE5")]
	[FieldOffset(Offset = "0x10")]
	public GameObject FireEffect;

	[Token(Token = "0x6005553")]
	[Address(RVA = "0x1C72868", Offset = "0x1C72868", VA = "0x1C72868")]
	public NPCAnimPlay()
	{
	}

	[Token(Token = "0x6005554")]
	[Address(RVA = "0x1C72870", Offset = "0x1C72870", VA = "0x1C72870")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6005555")]
	[Address(RVA = "0x1C729FC", Offset = "0x1C729FC", VA = "0x1C729FC")]
	public void OnAnimEventFire(bool isFire)
	{
	}
}
