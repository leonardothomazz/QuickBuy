﻿using QuickBuy.Dominio.Entidades;
using QuickBuy.Dominio.Interfaces;
using QuickBuy.Repositorio.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(QuickBuyContexto quickBuyContexto) : base(quickBuyContexto)
        {
        }
    }
}
