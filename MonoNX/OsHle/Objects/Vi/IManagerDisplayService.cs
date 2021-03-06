using MonoNX.OsHle.Ipc;
using System.Collections.Generic;

namespace MonoNX.OsHle.Objects.Vi
{
    class IManagerDisplayService : IIpcInterface
    {
        private Dictionary<int, ServiceProcessRequest> m_Commands;

        public IReadOnlyDictionary<int, ServiceProcessRequest> Commands => m_Commands;

        public IManagerDisplayService()
        {
            m_Commands = new Dictionary<int, ServiceProcessRequest>()
            {
                { 2010, CreateManagedLayer },
                { 6000, AddToLayerStack    }
            };
        }

        public static long CreateManagedLayer(ServiceCtx Context)
        {
            Context.ResponseData.Write(0L); //LayerId

            return 0;
        }

        public static long AddToLayerStack(ServiceCtx Context)
        {
            return 0;
        }
    }
}