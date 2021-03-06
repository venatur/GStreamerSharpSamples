// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	public partial class Promise : Gst.MiniObject {

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_promise_get_type();

		public static GLib.GType GType { 
			get {
				IntPtr raw_ret = gst_promise_get_type();
				GLib.GType ret = new GLib.GType(raw_ret);
				return ret;
			}
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_promise_expire(IntPtr raw);

		public void Expire() {
			gst_promise_expire(Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_promise_get_reply(IntPtr raw);

		public Gst.Structure RetrieveReply() {
			IntPtr raw_ret = gst_promise_get_reply(Handle);
			Gst.Structure ret = raw_ret == IntPtr.Zero ? null : (Gst.Structure) GLib.Opaque.GetOpaque (raw_ret, typeof (Gst.Structure), false);
			return ret;
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_promise_interrupt(IntPtr raw);

		public void Interrupt() {
			gst_promise_interrupt(Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern void gst_promise_reply(IntPtr raw, IntPtr s);

		public void Reply(Gst.Structure s) {
			s.Owned = false;
			gst_promise_reply(Handle, s == null ? IntPtr.Zero : s.Handle);
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern int gst_promise_wait(IntPtr raw);

		public Gst.PromiseResult Wait() {
			int raw_ret = gst_promise_wait(Handle);
			Gst.PromiseResult ret = (Gst.PromiseResult) raw_ret;
			return ret;
		}

		public Promise(IntPtr raw) : base(raw) {}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_promise_new();

		public Promise () 
		{
			Raw = gst_promise_new();
		}

		[DllImport("libgstreamer-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_promise_new_with_change_func(GstSharp.PromiseChangeFuncNative func, IntPtr user_data, GLib.DestroyNotify notify);

		public Promise (Gst.PromiseChangeFunc func, IntPtr user_data, GLib.DestroyNotify notify) 
		{
			GstSharp.PromiseChangeFuncWrapper func_wrapper = new GstSharp.PromiseChangeFuncWrapper (func);
			Raw = gst_promise_new_with_change_func(func_wrapper.NativeDelegate, user_data, notify);
		}


		// Internal representation of the wrapped structure ABI.
		static GLib.AbiStruct _abi_info = null;
		static public new GLib.AbiStruct abi_info {
			get {
				if (_abi_info == null)
					_abi_info = new GLib.AbiStruct (Gst.MiniObject.abi_info.Fields);

				return _abi_info;
			}
		}


		// End of the ABI representation.

#endregion
	}
}
