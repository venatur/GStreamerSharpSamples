// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace GstSharp {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
	internal delegate void LogFunctionNative(IntPtr category, int level, IntPtr file, IntPtr function, int line, IntPtr _object, IntPtr message, IntPtr user_data);

	internal class LogFunctionInvoker {

		LogFunctionNative native_cb;
		IntPtr __data;
		GLib.DestroyNotify __notify;

		~LogFunctionInvoker ()
		{
			if (__notify == null)
				return;
			__notify (__data);
		}

		internal LogFunctionInvoker (LogFunctionNative native_cb) : this (native_cb, IntPtr.Zero, null) {}

		internal LogFunctionInvoker (LogFunctionNative native_cb, IntPtr data) : this (native_cb, data, null) {}

		internal LogFunctionInvoker (LogFunctionNative native_cb, IntPtr data, GLib.DestroyNotify notify)
		{
			this.native_cb = native_cb;
			__data = data;
			__notify = notify;
		}

		internal Gst.LogFunction Handler {
			get {
				return new Gst.LogFunction(InvokeNative);
			}
		}

		void InvokeNative (Gst.DebugCategory category, Gst.DebugLevel level, string file, string function, int line, GLib.Object _object, Gst.DebugMessage message)
		{
			IntPtr native_category = GLib.Marshaller.StructureToPtrAlloc (category);
			IntPtr native_file = GLib.Marshaller.StringToPtrGStrdup (file);
			IntPtr native_function = GLib.Marshaller.StringToPtrGStrdup (function);
			native_cb (native_category, (int) level, native_file, native_function, line, _object == null ? IntPtr.Zero : _object.Handle, message == null ? IntPtr.Zero : message.Handle, __data);
			Marshal.FreeHGlobal (native_category);
			GLib.Marshaller.Free (native_file);
			GLib.Marshaller.Free (native_function);
		}
	}

	internal class LogFunctionWrapper {

		public void NativeCallback (IntPtr category, int level, IntPtr file, IntPtr function, int line, IntPtr _object, IntPtr message, IntPtr user_data)
		{
			try {
				managed (Gst.DebugCategory.New (category), (Gst.DebugLevel) level, GLib.Marshaller.Utf8PtrToString (file), GLib.Marshaller.Utf8PtrToString (function), line, GLib.Object.GetObject (_object), message == IntPtr.Zero ? null : (Gst.DebugMessage) GLib.Opaque.GetOpaque (message, typeof (Gst.DebugMessage), false));
				if (release_on_call)
					gch.Free ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		bool release_on_call = false;
		GCHandle gch;

		public void PersistUntilCalled ()
		{
			release_on_call = true;
			gch = GCHandle.Alloc (this);
		}

		internal LogFunctionNative NativeDelegate;
		Gst.LogFunction managed;

		public LogFunctionWrapper (Gst.LogFunction managed)
		{
			this.managed = managed;
			if (managed != null)
				NativeDelegate = new LogFunctionNative (NativeCallback);
		}

		public static Gst.LogFunction GetManagedDelegate (LogFunctionNative native)
		{
			if (native == null)
				return null;
			LogFunctionWrapper wrapper = (LogFunctionWrapper) native.Target;
			if (wrapper == null)
				return null;
			return wrapper.managed;
		}
	}
#endregion
}
