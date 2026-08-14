using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002C32")]
public interface IVoucher
{
	[Token(Token = "0x60126BB")]
	UIVoucherController OpenVoucherController(Transform parent);

	[Token(Token = "0x60126BC")]
	void OnVoucherItemClick(object[] data);

	[Token(Token = "0x60126BD")]
	UIVoucherItemController OpenVoucherItemController(Transform parent);
}
