using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003FE5")]
public class SharedSceneObjectManager : MonoSingleton<SharedSceneObjectManager>
{
	[Token(Token = "0x401AE81")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, SharedSceneObjectRecord> objectDict;

	[Token(Token = "0x601A025")]
	[Address(RVA = "0x21C6024", Offset = "0x21C6024", VA = "0x21C6024")]
	public SharedSceneObjectManager()
	{
	}

	[Token(Token = "0x601A026")]
	[Address(RVA = "0x21C5C20", Offset = "0x21C5C20", VA = "0x21C5C20")]
	public void Register(SharedSceneObject obj, int key)
	{
	}

	[Token(Token = "0x601A027")]
	[Address(RVA = "0x21C5EB8", Offset = "0x21C5EB8", VA = "0x21C5EB8")]
	public void Unregister(SharedSceneObject obj, int key)
	{
	}

	[Token(Token = "0x601A028")]
	[Address(RVA = "0x21C60F0", Offset = "0x21C60F0", VA = "0x21C60F0", Slot = "6")]
	protected override void OnDestroy()
	{
	}
}
