using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003C84")]
public abstract class UmaAvatarWithSlots<T> : UMAAvatarBase, _Attribute, IConvertible where T : IUintId
{
	[Token(Token = "0x4019B90")]
	[FieldOffset(Offset = "0x0")]
	protected Dictionary<string, T> _wardrobeRecipes;

	[Token(Token = "0x170019A3")]
	public Dictionary<string, T> WardrobeRecipes
	{
		[Token(Token = "0x601833D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601833C")]
	protected UmaAvatarWithSlots()
	{
	}

	[Token(Token = "0x601833E")]
	protected abstract T FindSlotRecipe(string recipe);

	[Token(Token = "0x601833F")]
	protected abstract string GetRecipeSlot(T recipe);

	[Token(Token = "0x6018340")]
	public void SetSlot(string recipe)
	{
	}

	[Token(Token = "0x6018341")]
	public void SetSlot(string recipe, uint id)
	{
	}

	[Token(Token = "0x6018342")]
	public virtual void SetSlot(string slot, T utr)
	{
	}

	[Token(Token = "0x6018343")]
	public void ClearSlot(string ws)
	{
	}

	[Token(Token = "0x6018344")]
	public void ClearSlots(List<string> slotsToClear)
	{
	}

	[Token(Token = "0x6018345")]
	public void ClearSlots()
	{
	}

	[Token(Token = "0x6018346")]
	public virtual bool IsSlotVisible(string slot)
	{
		return default(bool);
	}

	[Token(Token = "0x6018347")]
	public List<uint> GetIds()
	{
		return null;
	}

	[Token(Token = "0x6018348")]
	public string ToDebugString()
	{
		return null;
	}
}
