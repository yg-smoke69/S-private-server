using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A82")]
public class SceneEffectComponent : MonoBehaviour
{
	[Token(Token = "0x4005C81")]
	[FieldOffset(Offset = "0xC")]
	public string StrEffectResName;

	[Token(Token = "0x4005C82")]
	[FieldOffset(Offset = "0x10")]
	public GameObject objEffectTarget;

	[Token(Token = "0x60050FE")]
	[Address(RVA = "0x20DCF64", Offset = "0x20DCF64", VA = "0x20DCF64")]
	public SceneEffectComponent()
	{
	}

	[Token(Token = "0x60050FF")]
	[Address(RVA = "0x20DD004", Offset = "0x20DD004", VA = "0x20DD004")]
	private void Start()
	{
	}

	[Token(Token = "0x6005100")]
	[Address(RVA = "0x20DD064", Offset = "0x20DD064", VA = "0x20DD064")]
	public void BindEffectResource()
	{
	}
}
