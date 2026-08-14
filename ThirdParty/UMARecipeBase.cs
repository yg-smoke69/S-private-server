using Il2CppDummyDll;
using UMA;
using UnityEngine;

[Token(Token = "0x2003CF0")]
public abstract class UMARecipeBase : ScriptableObject
{
	[Token(Token = "0x4019E1E")]
	[FieldOffset(Offset = "0xC")]
	protected UMAData.UMARecipe umaRecipe;

	[Token(Token = "0x4019E1F")]
	[FieldOffset(Offset = "0x10")]
	protected bool cached;

	[Token(Token = "0x6018653")]
	[Address(RVA = "0x2A5BE58", Offset = "0x2A5BE58", VA = "0x2A5BE58")]
	protected UMARecipeBase()
	{
	}

	[Token(Token = "0x6018654")]
	public abstract void Load(UMAData.UMARecipe umaRecipe, UMAContext context);

	[Token(Token = "0x6018655")]
	public abstract void Save(UMAData.UMARecipe umaRecipe, UMAContext context);

	[Token(Token = "0x6018656")]
	[Address(RVA = "0x2A5F964", Offset = "0x2A5F964", VA = "0x2A5F964")]
	public UMAData.UMARecipe GetCachedRecipe(UMAContext context)
	{
		return null;
	}
}
