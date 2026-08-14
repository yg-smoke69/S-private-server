using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003C6F")]
public interface IUmaAvatarWithSlots : _Attribute
{
	[Token(Token = "0x6018207")]
	void SetSlot(string recipe);

	[Token(Token = "0x6018208")]
	void SetSlot(string recipe, uint id);

	[Token(Token = "0x6018209")]
	void ClearSlot(string slot);

	[Token(Token = "0x601820A")]
	void ClearSlots(List<string> slotsToClear);

	[Token(Token = "0x601820B")]
	void ClearSlots();

	[Token(Token = "0x601820C")]
	bool IsSlotVisible(string slot);

	[Token(Token = "0x601820D")]
	List<uint> GetIds();
}
