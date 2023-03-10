package com.example.rest;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.UnsupportedEncodingException;

import org.apache.http.HttpEntity;
import org.apache.http.HttpResponse;
import org.apache.http.client.ClientProtocolException;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.client.methods.HttpPost;
import org.apache.http.impl.client.DefaultHttpClient;
import org.json.JSONException;
import org.json.JSONObject;

import android.os.AsyncTask;
import android.util.Log;

public class JsonClass extends AsyncTask<String, Void, JSONObject>{
 
       InputStream input = null;
       JSONObject jObect = null;
       String json = "";
 
        //Recebe sua url

		@Override
		protected JSONObject doInBackground(String... url) {
			try {
                // default HttpClient
                DefaultHttpClient httpClient = new DefaultHttpClient();
                //HttpPost httpPost = new HttpPost(url);
                HttpGet httpGet = new HttpGet(url[0]);
 
                HttpResponse httpResponse = httpClient.execute(httpGet);
                HttpEntity httpEntity = httpResponse.getEntity();
                input = httpEntity.getContent();
 
            } catch (UnsupportedEncodingException e) {
                e.printStackTrace();
            } catch (ClientProtocolException e) {
                e.printStackTrace();
            } catch (IOException e) {
                e.printStackTrace();
            }
 
            try {
                BufferedReader reader = new BufferedReader(new InputStreamReader(
                        input, "iso-8859-1"), 8);
                StringBuilder sb = new StringBuilder();
                String line = null;
                while ((line = reader.readLine()) != null) {
                    sb.append(line + "\n");
                }
                input.close();
                json = sb.toString();
                Log.i("JRF", json);
            } catch (Exception e) {
                Log.e("Buffer Error", "Error converting result " + e.toString());
            }
 
            // Transforma a String de resposta em um JSonObject 
            try {
                jObect = new JSONObject(json);
            } catch (JSONException e) {
                Log.e("JSON Parser", "Error parsing data " + e.toString());
            }
 
            // retorna o objeto
            return jObect;
		}
    }
