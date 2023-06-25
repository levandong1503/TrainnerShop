import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TrannerShop',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44370/',
    redirectUri: baseUrl,
    clientId: 'TrannerShop_App',
    responseType: 'code',
    scope: 'offline_access TrannerShop',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44370',
      rootNamespace: 'Acme.TrannerShop',
    },
  },
} as Environment;
